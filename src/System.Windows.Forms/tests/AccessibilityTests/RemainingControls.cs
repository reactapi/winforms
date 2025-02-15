﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms;

namespace Accessibility_Core_App
{
    public partial class RemainingControls : Form
    {
        public RemainingControls()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = domainUpDown1;
            propertyGrid2.SelectedObject = trackBar1;
        }
    }
}
