using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace GUI
{
    class Graph
    {
        private int tickStart;
        private ZedGraphControl zedGraphControl1;
        private double value1 = 0;
        private double value2 = 0;
        private double value3 = 0;

        public void setValue1(double val)
        {
            this.value1 = val;
            drawGraph();
        }
        public void setValue2(double val)
        {
            this.value2 = val;
            drawGraph();
        }
        public void setValue3(double val)
        {
            this.value3 = val;
            drawGraph();
        }

       public  Graph(ZedGraphControl zedGraphControl1, string graphTitle, string xAxisTitle, string yAxisTitle, string name1,string name2,string name3)
        {
            this.zedGraphControl1 = zedGraphControl1;
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = graphTitle;
            myPane.XAxis.Title.Text = xAxisTitle;
            myPane.YAxis.Title.Text = yAxisTitle;

            // Save 1200 points.  At 50 ms sample rate, this is one minute
            // The RollingPointPairList is an efficient storage class that always
            // keeps a rolling set of point data without needing to shift any data values
            RollingPointPairList list1 = new RollingPointPairList(70000);
            RollingPointPairList list2 = new RollingPointPairList(70000);
            RollingPointPairList list3 = new RollingPointPairList(70000);

            // Initially, a curve is added with no data points (list is empty)
            // Color is blue, and there will be no symbol
            LineItem curve1 = myPane.AddCurve(name1, list1, Color.Red, SymbolType.None);
            LineItem curve2 = myPane.AddCurve(name2, list2, Color.Blue, SymbolType.None);
            LineItem curve3 = myPane.AddCurve(name3, list3, Color.Green, SymbolType.None);
            curve1.Line.Width = 1.75F;
            curve2.Line.Width = 1.75F;
            curve3.Line.Width = 1.75F;
           //curve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
            //curve.Line.Width = 2F;

        

            // Just manually control the X axis range so it scrolls continuously
            // instead of discrete step-sized jumps
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 50;
            myPane.XAxis.Scale.MinorStep = 0;
            myPane.XAxis.Scale.MajorStep = 5;

            // Scale the axes
            zedGraphControl1.AxisChange();

            // Save the beginning time for reference
            tickStart = Environment.TickCount;

        }
        public void drawGraph()
        {
            // Make sure that the curvelist has at least one curve
            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;

            // Get the first CurveItem in the graph
            LineItem curve1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            LineItem curve2 = zedGraphControl1.GraphPane.CurveList[1] as LineItem;
            LineItem curve3 = zedGraphControl1.GraphPane.CurveList[2] as LineItem;
            if (curve1 == null || curve3 == null || curve2 == null)
                return;

            // Get the PointPairList
            IPointListEdit list1 = curve1.Points as IPointListEdit;    
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            IPointListEdit list3 = curve3.Points as IPointListEdit;
            // If this is null, it means the reference at curve.Points does not
            // support IPointListEdit, so we won't be able to modify it
            if (list1 == null || list2 == null || list3 == null)
                return;

            // Time is measured in seconds
            double time = (Environment.TickCount - tickStart) / 1000.0;

            // 3 seconds per cycle
            list1.Add(time, value1);
            list2.Add(time, value2);
            list3.Add(time, value3);

            // Keep the X scale at a rolling 30 second interval, with one
            // major step between the max X value and the end of the axis
            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - 10.0;
            }

            // Make sure the Y axis is rescaled to accommodate actual data
            zedGraphControl1.AxisChange();
            // Force a redraw
            zedGraphControl1.Invalidate();
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.PointValueFormat = "0.000";
            zedGraphControl1.PointDateFormat = "d";
        }
    }
}
