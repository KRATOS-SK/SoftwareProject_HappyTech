namespace HappyTech
{
    partial class onlineTestTemplateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Gnostice.Core.Viewer.PageLayout pageLayout3 = new Gnostice.Core.Viewer.PageLayout();
            Gnostice.Documents.FormatterSettings formatterSettings3 = new Gnostice.Documents.FormatterSettings();
            Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings spreadSheetFormatterSettings3 = new Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings5 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins5 = new Gnostice.Documents.Margins();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions5 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions6 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.TXTFormatterSettings txtFormatterSettings3 = new Gnostice.Documents.TXTFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings6 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins6 = new Gnostice.Documents.Margins();
            Gnostice.Core.Graphics.RenderingSettings renderingSettings3 = new Gnostice.Core.Graphics.RenderingSettings();
            Gnostice.Core.Graphics.ImageRenderingSettings imageRenderingSettings3 = new Gnostice.Core.Graphics.ImageRenderingSettings();
            Gnostice.Core.Graphics.ResolutionSettings resolutionSettings3 = new Gnostice.Core.Graphics.ResolutionSettings();
            Gnostice.Core.Graphics.ShapeRenderingSettings shapeRenderingSettings3 = new Gnostice.Core.Graphics.ShapeRenderingSettings();
            Gnostice.Core.Graphics.TextRenderingSettings textRenderingSettings3 = new Gnostice.Core.Graphics.TextRenderingSettings();
            Gnostice.Core.Viewer.ViewerSettings viewerSettings3 = new Gnostice.Core.Viewer.ViewerSettings();
            Gnostice.Core.Viewer.Zoom zoom3 = new Gnostice.Core.Viewer.Zoom();
            Gnostice.Core.Viewer.PageLayout pageLayout4 = new Gnostice.Core.Viewer.PageLayout();
            Gnostice.Documents.FormatterSettings formatterSettings4 = new Gnostice.Documents.FormatterSettings();
            Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings spreadSheetFormatterSettings4 = new Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings7 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins7 = new Gnostice.Documents.Margins();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions7 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions8 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.TXTFormatterSettings txtFormatterSettings4 = new Gnostice.Documents.TXTFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings8 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins8 = new Gnostice.Documents.Margins();
            Gnostice.Core.Graphics.RenderingSettings renderingSettings4 = new Gnostice.Core.Graphics.RenderingSettings();
            Gnostice.Core.Graphics.ImageRenderingSettings imageRenderingSettings4 = new Gnostice.Core.Graphics.ImageRenderingSettings();
            Gnostice.Core.Graphics.ResolutionSettings resolutionSettings4 = new Gnostice.Core.Graphics.ResolutionSettings();
            Gnostice.Core.Graphics.ShapeRenderingSettings shapeRenderingSettings4 = new Gnostice.Core.Graphics.ShapeRenderingSettings();
            Gnostice.Core.Graphics.TextRenderingSettings textRenderingSettings4 = new Gnostice.Core.Graphics.TextRenderingSettings();
            Gnostice.Core.Viewer.ViewerSettings viewerSettings4 = new Gnostice.Core.Viewer.ViewerSettings();
            Gnostice.Core.Viewer.Zoom zoom4 = new Gnostice.Core.Viewer.Zoom();
            this.templateList = new System.Windows.Forms.ListBox();
            this.templateViewer = new Gnostice.Controls.WinForms.DocumentViewer();
            this.onlineTestViewer = new Gnostice.Controls.WinForms.DocumentViewer();
            this.selectTestReportButton = new System.Windows.Forms.Button();
            this.deleteTemplateButton = new System.Windows.Forms.Button();
            this.createNewTemplateButton = new System.Windows.Forms.Button();
            this.jobsList = new System.Windows.Forms.ComboBox();
            this.onlineTestHeaderLabel = new System.Windows.Forms.Label();
            this.useTemplateButton = new System.Windows.Forms.Button();
            this.editTemplateButton = new System.Windows.Forms.Button();
            this.openTestReportDialog = new System.Windows.Forms.OpenFileDialog();
            this.reviewerName = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // templateList
            // 
            this.templateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateList.FormattingEnabled = true;
            this.templateList.ItemHeight = 16;
            this.templateList.Location = new System.Drawing.Point(26, 129);
            this.templateList.Name = "templateList";
            this.templateList.Size = new System.Drawing.Size(182, 724);
            this.templateList.TabIndex = 0;
            this.templateList.SelectedIndexChanged += new System.EventHandler(this.templateList_SelectedIndexChanged);
            // 
            // templateViewer
            // 
            this.templateViewer.AllowInteractivity = false;
            this.templateViewer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.templateViewer.BorderWidth = 0F;
            this.templateViewer.HScrollBar.Enabled = false;
            this.templateViewer.HScrollBar.LargeChange = 40F;
            this.templateViewer.HScrollBar.Maximum = 0F;
            this.templateViewer.HScrollBar.Minimum = 0F;
            this.templateViewer.HScrollBar.SmallChange = 20F;
            this.templateViewer.HScrollBar.Value = 0F;
            this.templateViewer.HScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;
            this.templateViewer.HScrollBar.Visible = false;
            this.templateViewer.Location = new System.Drawing.Point(250, 129);
            this.templateViewer.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
            this.templateViewer.Name = "templateViewer";
            this.templateViewer.NavigationPane.BackColor = System.Drawing.SystemColors.Control;
            this.templateViewer.NavigationPane.Visibility = Gnostice.Core.Viewer.Visibility.Never;
            this.templateViewer.NavigationPane.WidthPercentage = 20;
            this.templateViewer.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
            this.templateViewer.PageBreakWidth = 10F;
            pageLayout3.Columns = 1;
            pageLayout3.HorizontalSpacing = 5D;
            pageLayout3.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.SinglePage;
            pageLayout3.ScrollMode = Gnostice.Core.Viewer.ScrollMode.Continuous;
            pageLayout3.ShowCoverPage = false;
            pageLayout3.VerticalSpacing = 5D;
            this.templateViewer.PageLayout = pageLayout3;
            this.templateViewer.PageRotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            spreadSheetFormatterSettings3.FormattingMode = Gnostice.Core.DOM.FormattingMode.PreferDocumentSettings;
            pageSettings5.Height = 11.6929F;
            margins5.Bottom = 1F;
            margins5.Footer = 0F;
            margins5.Header = 0F;
            margins5.Left = 1F;
            margins5.Right = 1F;
            margins5.Top = 1F;
            pageSettings5.Margin = margins5;
            pageSettings5.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            pageSettings5.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings5.Width = 8.2677F;
            spreadSheetFormatterSettings3.PageSettings = pageSettings5;
            sheetOptions5.Print = false;
            sheetOptions5.View = true;
            spreadSheetFormatterSettings3.ShowGridlines = sheetOptions5;
            sheetOptions6.Print = false;
            sheetOptions6.View = true;
            spreadSheetFormatterSettings3.ShowHeadings = sheetOptions6;
            formatterSettings3.SpreadSheet = spreadSheetFormatterSettings3;
            pageSettings6.Height = 11.6929F;
            margins6.Bottom = 1F;
            margins6.Footer = 0F;
            margins6.Header = 0F;
            margins6.Left = 1F;
            margins6.Right = 1F;
            margins6.Top = 1F;
            pageSettings6.Margin = margins6;
            pageSettings6.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            pageSettings6.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings6.Width = 8.2677F;
            txtFormatterSettings3.PageSettings = pageSettings6;
            formatterSettings3.TXT = txtFormatterSettings3;
            this.templateViewer.Preferences.FormatterSettings = formatterSettings3;
            this.templateViewer.Preferences.KeyNavigation = true;
            imageRenderingSettings3.InterpolationMode = Gnostice.Core.Graphics.InterpolationMode.NearestNeighbor;
            renderingSettings3.Image = imageRenderingSettings3;
            resolutionSettings3.DpiX = 96F;
            resolutionSettings3.DpiY = 96F;
            resolutionSettings3.ResolutionMode = Gnostice.Core.Graphics.ResolutionMode.UseSource;
            renderingSettings3.Resolution = resolutionSettings3;
            shapeRenderingSettings3.CompositingMode = Gnostice.Core.Graphics.CompositingMode.SourceOver;
            shapeRenderingSettings3.CompositingQuality = Gnostice.Core.Graphics.CompositingQuality.Default;
            shapeRenderingSettings3.PixelOffsetMode = Gnostice.Core.Graphics.PixelOffsetMode.HighQuality;
            shapeRenderingSettings3.SmoothingMode = Gnostice.Core.Graphics.SmoothingMode.AntiAlias;
            renderingSettings3.Shape = shapeRenderingSettings3;
            textRenderingSettings3.TextContrast = 4;
            textRenderingSettings3.TextRenderingHint = Gnostice.Core.Graphics.TextRenderingHint.AntiAlias;
            renderingSettings3.Text = textRenderingSettings3;
            this.templateViewer.Preferences.RenderingSettings = renderingSettings3;
            this.templateViewer.Preferences.Units = Gnostice.Core.Graphics.MeasurementUnit.Inches;
            viewerSettings3.AllowInteractivity = false;
            viewerSettings3.LowestRenderingDPI = 0F;
            viewerSettings3.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
            viewerSettings3.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
            viewerSettings3.PageBreakWidth = 10F;
            viewerSettings3.PageLayout = pageLayout3;
            viewerSettings3.Rotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            zoom3.InternalZoomMode = Gnostice.Core.Viewer.ZoomMode.FitWidth;
            zoom3.InternalZoomPercent = 100D;
            zoom3.ZoomMode = Gnostice.Core.Viewer.ZoomMode.FitWidth;
            zoom3.ZoomPercent = 100D;
            viewerSettings3.Zoom = zoom3;
            this.templateViewer.Preferences.ViewerSettings = viewerSettings3;
            this.templateViewer.Size = new System.Drawing.Size(711, 754);
            this.templateViewer.TabIndex = 1;
            this.templateViewer.VScrollBar.Enabled = false;
            this.templateViewer.VScrollBar.LargeChange = 40F;
            this.templateViewer.VScrollBar.Maximum = 0F;
            this.templateViewer.VScrollBar.Minimum = 0F;
            this.templateViewer.VScrollBar.SmallChange = 20F;
            this.templateViewer.VScrollBar.Value = 0F;
            this.templateViewer.VScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;
            this.templateViewer.VScrollBar.Visible = false;
            // 
            // onlineTestViewer
            // 
            this.onlineTestViewer.AllowInteractivity = false;
            this.onlineTestViewer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.onlineTestViewer.BorderWidth = 0F;
            this.onlineTestViewer.HScrollBar.Enabled = false;
            this.onlineTestViewer.HScrollBar.LargeChange = 40F;
            this.onlineTestViewer.HScrollBar.Maximum = 0F;
            this.onlineTestViewer.HScrollBar.Minimum = 0F;
            this.onlineTestViewer.HScrollBar.SmallChange = 20F;
            this.onlineTestViewer.HScrollBar.Value = 0F;
            this.onlineTestViewer.HScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;
            this.onlineTestViewer.HScrollBar.Visible = false;
            this.onlineTestViewer.Location = new System.Drawing.Point(1030, 129);
            this.onlineTestViewer.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
            this.onlineTestViewer.Name = "onlineTestViewer";
            this.onlineTestViewer.NavigationPane.BackColor = System.Drawing.SystemColors.Control;
            this.onlineTestViewer.NavigationPane.Visibility = Gnostice.Core.Viewer.Visibility.Never;
            this.onlineTestViewer.NavigationPane.WidthPercentage = 20;
            this.onlineTestViewer.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
            this.onlineTestViewer.PageBreakWidth = 10F;
            pageLayout4.Columns = 1;
            pageLayout4.HorizontalSpacing = 5D;
            pageLayout4.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.SinglePage;
            pageLayout4.ScrollMode = Gnostice.Core.Viewer.ScrollMode.Continuous;
            pageLayout4.ShowCoverPage = false;
            pageLayout4.VerticalSpacing = 5D;
            this.onlineTestViewer.PageLayout = pageLayout4;
            this.onlineTestViewer.PageRotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            spreadSheetFormatterSettings4.FormattingMode = Gnostice.Core.DOM.FormattingMode.PreferDocumentSettings;
            pageSettings7.Height = 11.6929F;
            margins7.Bottom = 1F;
            margins7.Footer = 0F;
            margins7.Header = 0F;
            margins7.Left = 1F;
            margins7.Right = 1F;
            margins7.Top = 1F;
            pageSettings7.Margin = margins7;
            pageSettings7.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            pageSettings7.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings7.Width = 8.2677F;
            spreadSheetFormatterSettings4.PageSettings = pageSettings7;
            sheetOptions7.Print = false;
            sheetOptions7.View = true;
            spreadSheetFormatterSettings4.ShowGridlines = sheetOptions7;
            sheetOptions8.Print = false;
            sheetOptions8.View = true;
            spreadSheetFormatterSettings4.ShowHeadings = sheetOptions8;
            formatterSettings4.SpreadSheet = spreadSheetFormatterSettings4;
            pageSettings8.Height = 11.6929F;
            margins8.Bottom = 1F;
            margins8.Footer = 0F;
            margins8.Header = 0F;
            margins8.Left = 1F;
            margins8.Right = 1F;
            margins8.Top = 1F;
            pageSettings8.Margin = margins8;
            pageSettings8.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            pageSettings8.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings8.Width = 8.2677F;
            txtFormatterSettings4.PageSettings = pageSettings8;
            formatterSettings4.TXT = txtFormatterSettings4;
            this.onlineTestViewer.Preferences.FormatterSettings = formatterSettings4;
            this.onlineTestViewer.Preferences.KeyNavigation = true;
            imageRenderingSettings4.InterpolationMode = Gnostice.Core.Graphics.InterpolationMode.NearestNeighbor;
            renderingSettings4.Image = imageRenderingSettings4;
            resolutionSettings4.DpiX = 96F;
            resolutionSettings4.DpiY = 96F;
            resolutionSettings4.ResolutionMode = Gnostice.Core.Graphics.ResolutionMode.UseSource;
            renderingSettings4.Resolution = resolutionSettings4;
            shapeRenderingSettings4.CompositingMode = Gnostice.Core.Graphics.CompositingMode.SourceOver;
            shapeRenderingSettings4.CompositingQuality = Gnostice.Core.Graphics.CompositingQuality.Default;
            shapeRenderingSettings4.PixelOffsetMode = Gnostice.Core.Graphics.PixelOffsetMode.HighQuality;
            shapeRenderingSettings4.SmoothingMode = Gnostice.Core.Graphics.SmoothingMode.AntiAlias;
            renderingSettings4.Shape = shapeRenderingSettings4;
            textRenderingSettings4.TextContrast = 4;
            textRenderingSettings4.TextRenderingHint = Gnostice.Core.Graphics.TextRenderingHint.AntiAlias;
            renderingSettings4.Text = textRenderingSettings4;
            this.onlineTestViewer.Preferences.RenderingSettings = renderingSettings4;
            this.onlineTestViewer.Preferences.Units = Gnostice.Core.Graphics.MeasurementUnit.Inches;
            viewerSettings4.AllowInteractivity = false;
            viewerSettings4.LowestRenderingDPI = 0F;
            viewerSettings4.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
            viewerSettings4.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
            viewerSettings4.PageBreakWidth = 10F;
            viewerSettings4.PageLayout = pageLayout4;
            viewerSettings4.Rotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            zoom4.InternalZoomMode = Gnostice.Core.Viewer.ZoomMode.FitWidth;
            zoom4.InternalZoomPercent = 100D;
            zoom4.ZoomMode = Gnostice.Core.Viewer.ZoomMode.FitWidth;
            zoom4.ZoomPercent = 100D;
            viewerSettings4.Zoom = zoom4;
            this.onlineTestViewer.Preferences.ViewerSettings = viewerSettings4;
            this.onlineTestViewer.Size = new System.Drawing.Size(711, 754);
            this.onlineTestViewer.TabIndex = 11;
            this.onlineTestViewer.VScrollBar.Enabled = false;
            this.onlineTestViewer.VScrollBar.LargeChange = 40F;
            this.onlineTestViewer.VScrollBar.Maximum = 0F;
            this.onlineTestViewer.VScrollBar.Minimum = 0F;
            this.onlineTestViewer.VScrollBar.SmallChange = 20F;
            this.onlineTestViewer.VScrollBar.Value = 0F;
            this.onlineTestViewer.VScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;
            this.onlineTestViewer.VScrollBar.Visible = false;
            // 
            // selectTestReportButton
            // 
            this.selectTestReportButton.Location = new System.Drawing.Point(1607, 98);
            this.selectTestReportButton.Name = "selectTestReportButton";
            this.selectTestReportButton.Size = new System.Drawing.Size(134, 23);
            this.selectTestReportButton.TabIndex = 3;
            this.selectTestReportButton.Text = "Select File To Display";
            this.selectTestReportButton.UseVisualStyleBackColor = true;
            this.selectTestReportButton.Click += new System.EventHandler(this.selectCVButton_Click);
            // 
            // deleteTemplateButton
            // 
            this.deleteTemplateButton.Location = new System.Drawing.Point(26, 860);
            this.deleteTemplateButton.Name = "deleteTemplateButton";
            this.deleteTemplateButton.Size = new System.Drawing.Size(84, 23);
            this.deleteTemplateButton.TabIndex = 4;
            this.deleteTemplateButton.Text = "Delete";
            this.deleteTemplateButton.UseVisualStyleBackColor = true;
            this.deleteTemplateButton.Click += new System.EventHandler(this.deleteTemplateButton_Click);
            // 
            // createNewTemplateButton
            // 
            this.createNewTemplateButton.Location = new System.Drawing.Point(116, 860);
            this.createNewTemplateButton.Name = "createNewTemplateButton";
            this.createNewTemplateButton.Size = new System.Drawing.Size(92, 23);
            this.createNewTemplateButton.TabIndex = 5;
            this.createNewTemplateButton.Text = "Create New";
            this.createNewTemplateButton.UseVisualStyleBackColor = true;
            this.createNewTemplateButton.Click += new System.EventHandler(this.createNewTemplateButton_Click);
            // 
            // jobsList
            // 
            this.jobsList.AllowDrop = true;
            this.jobsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsList.FormattingEnabled = true;
            this.jobsList.Location = new System.Drawing.Point(26, 81);
            this.jobsList.Name = "jobsList";
            this.jobsList.Size = new System.Drawing.Size(182, 24);
            this.jobsList.TabIndex = 6;
            // 
            // onlineTestHeaderLabel
            // 
            this.onlineTestHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.onlineTestHeaderLabel.AutoSize = true;
            this.onlineTestHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineTestHeaderLabel.Location = new System.Drawing.Point(637, 25);
            this.onlineTestHeaderLabel.Name = "onlineTestHeaderLabel";
            this.onlineTestHeaderLabel.Size = new System.Drawing.Size(705, 78);
            this.onlineTestHeaderLabel.TabIndex = 7;
            this.onlineTestHeaderLabel.Text = "Online Test Templates";
            // 
            // useTemplateButton
            // 
            this.useTemplateButton.Location = new System.Drawing.Point(1467, 889);
            this.useTemplateButton.Name = "useTemplateButton";
            this.useTemplateButton.Size = new System.Drawing.Size(134, 23);
            this.useTemplateButton.TabIndex = 8;
            this.useTemplateButton.Text = "Use Template";
            this.useTemplateButton.UseVisualStyleBackColor = true;
            this.useTemplateButton.Click += new System.EventHandler(this.useTemplateButton_Click);
            // 
            // editTemplateButton
            // 
            this.editTemplateButton.Location = new System.Drawing.Point(1607, 889);
            this.editTemplateButton.Name = "editTemplateButton";
            this.editTemplateButton.Size = new System.Drawing.Size(134, 23);
            this.editTemplateButton.TabIndex = 9;
            this.editTemplateButton.Text = "Edit Template";
            this.editTemplateButton.UseVisualStyleBackColor = true;
            this.editTemplateButton.Click += new System.EventHandler(this.editTemplateButton_Click);
            // 
            // openTestReportDialog
            // 
            this.openTestReportDialog.FileName = "openTestReportDialog";
            // 
            // reviewerName
            // 
            this.reviewerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reviewerName.AutoSize = true;
            this.reviewerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewerName.Location = new System.Drawing.Point(1650, 15);
            this.reviewerName.Name = "reviewerName";
            this.reviewerName.Size = new System.Drawing.Size(109, 20);
            this.reviewerName.TabIndex = 12;
            this.reviewerName.Text = "reviewerName";
            // 
            // greetingLabel
            // 
            this.greetingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.Location = new System.Drawing.Point(1605, 15);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(49, 20);
            this.greetingLabel.TabIndex = 13;
            this.greetingLabel.Text = "Hello,";
            // 
            // onlineTestTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 924);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.reviewerName);
            this.Controls.Add(this.editTemplateButton);
            this.Controls.Add(this.useTemplateButton);
            this.Controls.Add(this.onlineTestHeaderLabel);
            this.Controls.Add(this.jobsList);
            this.Controls.Add(this.createNewTemplateButton);
            this.Controls.Add(this.deleteTemplateButton);
            this.Controls.Add(this.selectTestReportButton);
            this.Controls.Add(this.onlineTestViewer);
            this.Controls.Add(this.templateViewer);
            this.Controls.Add(this.templateList);
            this.Icon = global::HappyTech.Properties.Resources.logoIcon;
            this.Name = "onlineTestTemplateForm";
            this.Text = "Online Test Templates";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CVTemplateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox templateList;
        private Gnostice.Controls.WinForms.DocumentViewer templateViewer;
        private System.Windows.Forms.Button selectTestReportButton;
        private System.Windows.Forms.Button deleteTemplateButton;
        private System.Windows.Forms.Button createNewTemplateButton;
        private System.Windows.Forms.ComboBox jobsList;
        private System.Windows.Forms.Label onlineTestHeaderLabel;
        private System.Windows.Forms.Button useTemplateButton;
        private System.Windows.Forms.Button editTemplateButton;
        private System.Windows.Forms.OpenFileDialog openTestReportDialog;
        private Gnostice.Controls.WinForms.DocumentViewer onlineTestViewer;
        private System.Windows.Forms.Label reviewerName;
        private System.Windows.Forms.Label greetingLabel;
    }
}