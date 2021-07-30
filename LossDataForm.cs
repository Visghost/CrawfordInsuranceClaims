using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrawfordInsuranceClaims
{
    public partial class LossDataForm : Form
    {
        public LossDataForm(string displayName)
        {
            InitializeComponent();

            UsersDisplayName.Text = "Hi, " + displayName;
            Console.WriteLine($"Retrieving the loss data, while logined in as {displayName}..");

            RetrieveLossTypesProcedure retrieveLossTypes = new RetrieveLossTypesProcedure();
            foreach (var lossType in retrieveLossTypes.FoundTypes)
            {
                LossTypesGrid.Rows.Add(new object[] { lossType.LossTypeID, lossType.LossTypeCode, lossType.LossTypeDescription });
            }
        }

    }
}
