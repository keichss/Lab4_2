using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_2
{
    public partial class Form1 : Form
    {
        Model modelA;
        Model modelB;
        Model modelC;
        public Form1()
        {
            InitializeComponent();
            modelA = new Model();
            modelB = new Model();
            modelC = new Model();
            modelA.observer += new System.EventHandler(this.UpdateModel);
            modelB.observer += new System.EventHandler(this.UpdateModel);
            modelC.observer += new System.EventHandler(this.UpdateModel);
            modelC.setValue(Properties.Settings.Default.CVal);
            modelB.setValue(Properties.Settings.Default.BVal);
            modelA.setValue(Properties.Settings.Default.AVal);
            Properties.Settings.Default.Save();
        }

        private void numUDA_ValueChanged(object sender, EventArgs e)
        {
            if ((Decimal.ToInt32(numUDA.Value) >= modelA.getMin()) && (Decimal.ToInt32(numUDA.Value) <= modelA.getMax()))
            {
                if (modelA.getValue() <= modelC.getValue())
                    modelA.setValue(Decimal.ToInt32(numUDA.Value));
                else
                    modelC.setValue(Decimal.ToInt32(numUDA.Value));
                if (modelA.getValue() > modelB.getValue())
                    modelB.setValue(modelA.getValue());
            }
            else
            {
                numUDA.Value = modelA.getValue();
            }
            Properties.Settings.Default.AVal = modelA.getValue();
            Properties.Settings.Default.Save();
        }

        private void numUDB_ValueChanged(object sender, EventArgs e)
        {
            if ((Decimal.ToInt32(numUDB.Value) >= modelB.getMin()) && (Decimal.ToInt32(numUDB.Value) <= modelB.getMax()))
            {
                if (modelA.getValue() > modelB.getValue())
                    modelB.setValue(modelA.getValue());
                else
                if (modelC.getValue() < modelB.getValue())
                    modelB.setValue(modelC.getValue());
                else
                    modelB.setValue(Decimal.ToInt32(numUDB.Value));
            }
            else
            {
                numUDB.Value = modelB.getValue();
            }
            Properties.Settings.Default.BVal = modelB.getValue();
            Properties.Settings.Default.Save();
        }

        private void numUDC_ValueChanged(object sender, EventArgs e)
        {
            if ((Decimal.ToInt32(numUDC.Value) >= modelC.getMin()) && (Decimal.ToInt32(numUDC.Value) <= modelC.getMax()))
            {
                if (modelC.getValue() >= modelA.getValue())
                    modelC.setValue(Decimal.ToInt32(numUDC.Value));
                else
                    modelA.setValue(Decimal.ToInt32(numUDC.Value));
                if (modelC.getValue() < modelB.getValue())
                    modelB.setValue(Decimal.ToInt32(numUDC.Value));
            }
            else
            {
                numUDC.Value = modelC.getValue();
            }
            Properties.Settings.Default.CVal = modelC.getValue();
            Properties.Settings.Default.Save();
        }

        private void tbA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((Int32.Parse(tbA.Text) >= modelA.getMin()) && (Int32.Parse(tbA.Text) <= modelA.getMax()))
                {
                    if (modelA.getValue() <= modelC.getValue())
                        modelA.setValue(Int32.Parse(tbA.Text));
                    else
                        modelC.setValue(Int32.Parse(tbA.Text));
                    if (modelA.getValue() > modelB.getValue())
                        modelB.setValue(modelA.getValue());
                }
                else
                {
                    tbA.Text = modelA.getValue().ToString();
                }
            }
            Properties.Settings.Default.AVal = modelA.getValue();
            Properties.Settings.Default.Save();
        }

        private void tbB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((Int32.Parse(tbB.Text) >= modelB.getMin()) && (Int32.Parse(tbB.Text) <= modelB.getMax()))
                {
                    if (modelA.getValue() > modelB.getValue())
                        modelB.setValue(modelA.getValue());
                    else
                    if (modelC.getValue() < modelB.getValue())
                        modelB.setValue(modelC.getValue());
                    else
                        modelB.setValue(Int32.Parse(tbB.Text));
                }
                else
                {
                    tbB.Text = modelB.getValue().ToString();
                }
            }
            Properties.Settings.Default.BVal = modelB.getValue();
            Properties.Settings.Default.Save();
        }

        private void tbC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((Int32.Parse(tbC.Text) >= modelC.getMin()) && (Int32.Parse(tbC.Text) <= modelC.getMax()))
                {
                    if (modelC.getValue() >= modelA.getValue())

                        modelC.setValue(Int32.Parse(tbC.Text));
                    else
                        modelA.setValue(Int32.Parse(tbC.Text));
                    if (modelC.getValue() < modelB.getValue())
                        modelB.setValue(modelC.getValue());
                }
                else
                {
                    tbC.Text = modelC.getValue().ToString();
                }
            }
            Properties.Settings.Default.CVal = modelC.getValue();
            Properties.Settings.Default.Save();
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            if ((trackBarA.Value >= modelA.getMin()) && (trackBarA.Value <= modelA.getMax()))
            {
                if (modelA.getValue() <= modelC.getValue())

                    modelA.setValue(trackBarA.Value);
                else
                    modelC.setValue(trackBarA.Value);
                if (modelA.getValue() > modelB.getValue())
                    modelB.setValue(modelA.getValue());
            }
            else
            {
                trackBarA.Value = modelA.getValue();
            }
            Properties.Settings.Default.AVal = modelA.getValue();
            Properties.Settings.Default.Save();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            if ((trackBarB.Value >= modelB.getMin()) && (trackBarB.Value <= modelB.getMax()))
            {
                if (modelA.getValue() > modelB.getValue())
                    modelB.setValue(modelA.getValue());
                else
            if (modelC.getValue() < modelB.getValue())
                    modelB.setValue(modelC.getValue());
                else
                    modelB.setValue(trackBarB.Value);
            }
            else
            {
                trackBarB.Value = modelB.getValue();
            }
            Properties.Settings.Default.BVal = modelB.getValue();
            Properties.Settings.Default.Save();
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            if ((trackBarC.Value >= modelC.getMin()) && (trackBarC.Value <= modelC.getMax()))
            {
                if (modelC.getValue() >= modelA.getValue())

                    modelC.setValue(trackBarC.Value);
                else
                    modelA.setValue(trackBarC.Value);
                if (modelC.getValue() < modelB.getValue())
                    modelB.setValue(trackBarC.Value);
            }
            else
            {
                trackBarC.Value = modelC.getValue();
            }
            Properties.Settings.Default.CVal = modelC.getValue();
            Properties.Settings.Default.Save();
        }
        private void UpdateModel(object sender, EventArgs e)
        {

            tbA.Text = modelA.getValue().ToString();
            tbB.Text = modelB.getValue().ToString();
            tbC.Text = modelC.getValue().ToString();
            numUDA.Value = modelA.getValue();
            numUDB.Value = modelB.getValue();
            numUDC.Value = modelC.getValue();
            trackBarA.Value = modelA.getValue();
            trackBarB.Value = modelB.getValue();
            trackBarC.Value = modelC.getValue();

        }
    }
}
public class Model
{
    private int value, max, min;

    public System.EventHandler observer;
    public Model()
    {
        value = 0;
        max = 100;
        min = 0;
    }
    public void setValue(int _value)
    {
        value = _value;

        observer.Invoke(this, null);

    }

    public int getMin()
    {
        return min;
    }
    public int getMax()
    {
        return max;
    }
    public int getValue()
    {
        return value;
    }
}
