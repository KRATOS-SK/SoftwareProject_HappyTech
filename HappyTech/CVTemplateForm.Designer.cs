namespace HappyTech
{
    partial class CVTemplateForm
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
            Gnostice.Core.Viewer.PageLayout pageLayout5 = new Gnostice.Core.Viewer.PageLayout();
            Gnostice.Documents.FormatterSettings formatterSettings5 = new Gnostice.Documents.FormatterSettings();
            Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings spreadSheetFormatterSettings5 = new Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings9 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins9 = new Gnostice.Documents.Margins();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions9 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions10 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.TXTFormatterSettings txtFormatterSettings5 = new Gnostice.Documents.TXTFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings10 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins10 = new Gnostice.Documents.Margins();
            Gnostice.Core.Graphics.RenderingSettings renderingSettings5 = new Gnostice.Core.Graphics.RenderingSettings();
            Gnostice.Core.Graphics.ImageRenderingSettings imageRenderingSettings5 = new Gnostice.Core.Graphics.ImageRenderingSettings();
            Gnostice.Core.Graphics.ResolutionSettings resolutionSettings5 = new Gnostice.Core.Graphics.ResolutionSettings();
            Gnostice.Core.Graphics.ShapeRenderingSettings shapeRenderingSettings5 = new Gnostice.Core.Graphics.ShapeRenderingSettings();
            Gnostice.Core.Graphics.TextRenderingSettings textRenderingSettings5 = new Gnostice.Core.Graphics.TextRenderingSettings();
            Gnostice.Core.Viewer.ViewerSettings viewerSettings5 = new Gnostice.Core.Viewer.ViewerSettings();
            Gnostice.Core.Viewer.Zoom zoom5 = new Gnostice.Core.Viewer.Zoom();
            Gnostice.Core.Viewer.PageLayout pageLayout6 = new Gnostice.Core.Viewer.PageLayout();
            Gnostice.Documents.FormatterSettings formatterSettings6 = new Gnostice.Documents.FormatterSettings();
            Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings spreadSheetFormatterSettings6 = new Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings11 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins11 = new Gnostice.Documents.Margins();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions11 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions12 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.TXTFormatterSettings txtFormatterSettings6 = new Gnostice.Documents.TXTFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings12 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins12 = new Gnostice.Documents.Margins();
            Gnostice.Core.Graphics.RenderingSettings renderingSettings6 = new Gnostice.Core.Graphics.RenderingSettings();
            Gnostice.Core.Graphics.ImageRenderingSettings imageRenderingSettings6 = new Gnostice.Core.Graphics.ImageRenderingSettings();
            Gnostice.Core.Graphics.ResolutionSettings resolutionSettings6 = new Gnostice.Core.Graphics.ResolutionSettings();
            Gnostice.Core.Graphics.ShapeRenderingSettings shapeRenderingSettings6 = new Gnostice.Core.Graphics.ShapeRenderingSettings();
            Gnostice.Core.Graphics.TextRenderingSettings textRenderingSettings6 = new Gnostice.Core.Graphics.TextRenderingSettings();
            Gnostice.Core.Viewer.ViewerSettings viewerSettings6 = new Gnostice.Core.Viewer.ViewerSettings();
            Gnostice.Core.Viewer.Zoom zoom6 = new Gnostice.Core.Viewer.Zoom();
            this.templateList = new System.Windows.Forms.ListBox();
            this.templateViewer = new Gnostice.Controls.WinForms.DocumentViewer();
            this.cvViewer = new Gnostice.Controls.WinForms.DocumentViewer();
            this.selectCVButton = new System.Windows.Forms.Button();
            this.deleteTemplateButton = new System.Windows.Forms.Button();
            this.createNewTemplateButton = new System.Windows.Forms.Button();
            this.jobsList = new System.Windows.Forms.ComboBox();
            this.cvTemplateHeaderLabel = new System.Windows.Forms.Label();
            this.useTemplateButton = new System.Windows.Forms.Button();
            this.editTemplateButton = new System.Windows.Forms.Button();
            this.openCVDialog = new System.Windows.Forms.OpenFileDialog();
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
            pageLayout5.Columns = 1;
            pageLayout5.HorizontalSpacing = 5D;
            pageLayout5.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.SinglePage;
            pageLayout5.ScrollMode = Gnostice.Core.Viewer.ScrollMode.Continuous;
            pageLayout5.ShowCoverPage = false;
            pageLayout5.VerticalSpacing = 5D;
            this.templateViewer.PageLayout = pageLayout5;
            this.templateViewer.PageRotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            spreadSheetFormatterSettings5.FormattingMode = Gnostice.Core.DOM.FormattingMode.PreferDocumentSettings;
            pageSettings9.Height = 11.6929F;
            margins9.Bottom = 1F;
            margins9.Footer = 0F;
            margins9.Header = 0F;
            margins9.Left = 1F;
            margins9.Right = 1F;
            margins9.Top = 1F;
            pageSettings9.Margin = margins9;
            pageSettings9.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            pageSettings9.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings9.Width = 8.2677F;
            spreadSheetFormatterSettings5.PageSettings = pageSettings9;
            sheetOptions9.Print = false;
            sheetOptions9.View = true;
            spreadSheetFormatterSettings5.ShowGridlines = sheetOptions9;
            sheetOptions10.Print = false;
            sheetOptions10.View = true;
            spreadSheetFormatterSettings5.ShowHeadings = sheetOptions10;
            formatterSettings5.SpreadSheet = spreadSheetFormatterSettings5;
            pageSettings10.Height = 11.6929F;
            margins10.Bottom = 1F;
            margins10.Footer = 0F;
            margins10.Header = 0F;
            margins10.Left = 1F;
            margins10.Right = 1F;
            margins10.Top = 1F;
            pageSettings10.Margin = margins10;
            pageSettings10.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            pageSettings10.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings10.Width = 8.2677F;
            txtFormatterSettings5.PageSettings = pageSettings10;
            formatterSettings5.TXT = txtFormatterSettings5;
            this.templateViewer.Preferences.FormatterSettings = formatterSettings5;
            this.templateViewer.Preferences.KeyNavigation = true;
            imageRenderingSettings5.InterpolationMode = Gnostice.Core.Graphics.InterpolationMode.NearestNeighbor;
            renderingSettings5.Image = imageRenderingSettings5;
            resolutionSettings5.DpiX = 96F;
            resolutionSettings5.DpiY = 96F;
            resolutionSettings5.ResolutionMode = Gnostice.Core.Graphics.ResolutionMode.UseSource;
            renderingSettings5.Resolution = resolutionSettings5;
            shapeRenderingSettings5.CompositingMode = Gnostice.Core.Graphics.CompositingMode.SourceOver;
            shapeRenderingSettings5.CompositingQuality = Gnostice.Core.Graphics.CompositingQuality.Default;
            shapeRenderingSettings5.PixelOffsetMode = Gnostice.Core.Graphics.PixelOffsetMode.HighQuality;
            shapeRenderingSettings5.SmoothingMode = Gnostice.Core.Graphics.SmoothingMode.AntiAlias;
            renderingSettings5.Shape = shapeRenderingSettings5;
            textRenderingSettings5.TextContrast = 4;
            textRenderingSettings5.TextRenderingHint = Gnostice.Core.Graphics.TextRenderingHint.AntiAlias;
            renderingSettings5.Text = textRenderingSettings5;
            this.templateViewer.Preferences.RenderingSettings = renderingSettings5;
            this.templateViewer.Preferences.Units = Gnostice.Core.Graphics.MeasurementUnit.Inches;
            viewerSettings5.AllowInteractivity = false;
            viewerSettings5.LowestRenderingDPI = 0F;
            viewerSettings5.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
            viewerSettings5.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
            viewerSettings5.PageBreakWidth = 10F;
            viewerSettings5.PageLayout = pageLayout5;
            viewerSettings5.Rotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            zoom5.InternalZoomMode = Gnostice.Core.Viewer.ZoomMode.FitWidth;
            zoom5.InternalZoomPercent = 100D;
            zoom5.ZoomMode = Gnostice.Core.Viewer.ZoomMode.FitWidth;
            zoom5.ZoomPercent = 100D;
            viewerSettings5.Zoom = zoom5;
            this.templateViewer.Preferences.ViewerSettings = viewerSettings5;
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
            // cvViewer
            // 
            this.cvViewer.AllowInteractivity = false;
            this.cvViewer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cvViewer.BorderWidth = 0F;
            this.cvViewer.HScrollBar.Enabled = false;
            this.cvViewer.HScrollBar.LargeChange = 40F;
            this.cvViewer.HScrollBar.Maximum = 0F;
            this.cvViewer.HScrollBar.Minimum = 0F;
            this.cvViewer.HScrollBar.SmallChange = 20F;
            this.cvViewer.HScrollBar.Value = 0F;
            this.cvViewer.HScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;
            this.cvViewer.HScrollBar.Visible = false;
            this.cvViewer.Location = new System.Drawing.Point(1030, 129);
            this.cvViewer.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
            this.cvViewer.Name = "cvViewer";
            this.cvViewer.NavigationPane.BackColor = System.Drawing.SystemColors.Control;
            this.cvViewer.NavigationPane.Visibility = Gnostice.Core.Viewer.Visibility.Never;
            this.cvViewer.NavigationPane.WidthPercentage = 20;
            this.cvViewer.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
            this.cvViewer.PageBreakWidth = 10F;
            pageLayout6.Columns = 1;
            pageLayout6.HorizontalSpacing = 5D;
            pageLayout6.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.SinglePage;
            pageLayout6.ScrollMode = Gnostice.Core.Viewer.ScrollMode.Continuous;
            pageLayout6.ShowCoverPage = false;
            pageLayout6.VerticalSpacing = 5D;
            this.cvViewer.PageLayout = pageLayout6;
            this.cvViewer.PageRotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            spreadSheetFormatterSettings6.FormattingMode = Gnostice.Core.DOM.FormattingMode.PreferDocumentSettings;
            pageSettings11.Height = 11.6929F;
            margins11.Bottom = 1F;
            margins11.Footer = 0F;
            margins11.Header = 0F;
            margins11.Left = 1F;
            margins11.Right = 1F;
            margins11.Top = 1F;
            pageSettings11.Margin = margins11;
            pageSettings11.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            pageSettings11.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings11.Width = 8.2677F;
            spreadSheetFormatterSettings6.PageSettings = pageSettings11;
            sheetOptions11.Print = false;
            sheetOptions11.View = true;
            spreadSheetFormatterSettings6.ShowGridlines = sheetOptions11;
            sheetOptions12.Print = false;
            sheetOptions12.View = true;
            spreadSheetFormatterSettings6.ShowHeadings = sheetOptions12;
            formatterSettings6.SpreadSheet = spreadSheetFormatterSettings6;
            pageSettings12.Height = 11.6929F;
            margins12.Bottom = 1F;
            margins12.Footer = 0F;
            margins12.Header = 0F;
            margins12.Left = 1F;
            margins12.Right = 1F;
            margins12.Top = 1F;
            pageSettings12.Margin = margins12;
            pageSettings12.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            pageSettings12.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings12.Width = 8.2677F;
            txtFormatterSettings6.PageSettings = pageSettings12;
            formatterSettings6.TXT = txtFormatterSettings6;
            this.cvViewer.Preferences.FormatterSettings = formatterSettings6;
            this.cvViewer.Preferences.KeyNavigation = true;
            imageRenderingSettings6.InterpolationMode = Gnostice.Core.Graphics.InterpolationMode.NearestNeighbor;
            renderingSettings6.Image = imageRenderingSettings6;
            resolutionSettings6.DpiX = 96F;
            resolutionSettings6.DpiY = 96F;
            resolutionSettings6.ResolutionMode = Gnostice.Core.Graphics.ResolutionMode.UseSource;
            renderingSettings6.Resolution = resolutionSettings6;
            shapeRenderingSettings6.CompositingMode = Gnostice.Core.Graphics.CompositingMode.SourceOver;
            shapeRenderingSettings6.CompositingQuality = Gnostice.Core.Graphics.CompositingQuality.Default;
            shapeRenderingSettings6.PixelOffsetMode = Gnostice.Core.Graphics.PixelOffsetMode.HighQuality;
            shapeRenderingSettings6.SmoothingMode = Gnostice.Core.Graphics.SmoothingMode.AntiAlias;
            renderingSettings6.Shape = shapeRenderingSettings6;
            textRenderingSettings6.TextContrast = 4;
            textRenderingSettings6.TextRenderingHint = Gnostice.Core.Graphics.TextRenderingHint.AntiAlias;
            renderingSettings6.Text = textRenderingSettings6;
            this.cvViewer.Preferences.RenderingSettings = renderingSettings6;
            this.cvViewer.Preferences.Units = Gnostice.Core.Graphics.MeasurementUnit.Inches;
            viewerSettings6.AllowInteractivity = false;
            viewerSettings6.LowestRenderingDPI = 0F;
            viewerSettings6.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
            viewerSettings6.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
            viewerSettings6.PageBreakWidth = 10F;
            viewerSettings6.PageLayout = pageLayout6;
            viewerSettings6.Rotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            zoom6.InternalZoomMode = Gnostice.Core.Viewer.ZoomMode.FitWidth;
            zoom6.InternalZoomPercent = 100D;
            zoom6.ZoomMode = Gnostice.Core.Viewer.ZoomMode.FitWidth;
            zoom6.ZoomPercent = 100D;
            viewerSettings6.Zoom = zoom6;
            this.cvViewer.Preferences.ViewerSettings = viewerSettings6;
            this.cvViewer.Size = new System.Drawing.Size(711, 754);
            this.cvViewer.TabIndex = 11;
            this.cvViewer.VScrollBar.Enabled = false;
            this.cvViewer.VScrollBar.LargeChange = 40F;
            this.cvViewer.VScrollBar.Maximum = 0F;
            this.cvViewer.VScrollBar.Minimum = 0F;
            this.cvViewer.VScrollBar.SmallChange = 20F;
            this.cvViewer.VScrollBar.Value = 0F;
            this.cvViewer.VScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;
            this.cvViewer.VScrollBar.Visible = false;
            // 
            // selectCVButton
            // 
            this.selectCVButton.Location = new System.Drawing.Point(1607, 98);
            this.selectCVButton.Name = "selectCVButton";
            this.selectCVButton.Size = new System.Drawing.Size(134, 23);
            this.selectCVButton.TabIndex = 3;
            this.selectCVButton.Text = "Select File To Display";
            this.selectCVButton.UseVisualStyleBackColor = true;
            this.selectCVButton.Click += new System.EventHandler(this.selectCVButton_Click);
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
            // cvTemplateHeaderLabel
            // 
            this.cvTemplateHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cvTemplateHeaderLabel.AutoSize = true;
            this.cvTemplateHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvTemplateHeaderLabel.Location = new System.Drawing.Point(715, 25);
            this.cvTemplateHeaderLabel.Name = "cvTemplateHeaderLabel";
            this.cvTemplateHeaderLabel.Size = new System.Drawing.Size(466, 78);
            this.cvTemplateHeaderLabel.TabIndex = 7;
            this.cvTemplateHeaderLabel.Text = "CV Templates";
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
            // openCVDialog
            // 
            this.openCVDialog.FileName = "openCVDialog";
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
            // CVTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 924);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.reviewerName);
            this.Controls.Add(this.editTemplateButton);
            this.Controls.Add(this.useTemplateButton);
            this.Controls.Add(this.cvTemplateHeaderLabel);
            this.Controls.Add(this.jobsList);
            this.Controls.Add(this.createNewTemplateButton);
            this.Controls.Add(this.deleteTemplateButton);
            this.Controls.Add(this.selectCVButton);
            this.Controls.Add(this.cvViewer);
            this.Controls.Add(this.templateViewer);
            this.Controls.Add(this.templateList);
            this.Icon = global::HappyTech.Properties.Resources.logoIcon;
            this.Name = "CVTemplateForm";
            this.Text = "CV Templates";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CVTemplateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox templateList;
        private Gnostice.Controls.WinForms.DocumentViewer templateViewer;
        private System.Windows.Forms.Button selectCVButton;
        private System.Windows.Forms.Button deleteTemplateButton;
        private System.Windows.Forms.Button createNewTemplateButton;
        private System.Windows.Forms.ComboBox jobsList;
        private System.Windows.Forms.Label cvTemplateHeaderLabel;
        private System.Windows.Forms.Button useTemplateButton;
        private System.Windows.Forms.Button editTemplateButton;
        private System.Windows.Forms.OpenFileDialog openCVDialog;
        private Gnostice.Controls.WinForms.DocumentViewer cvViewer;
        private System.Windows.Forms.Label reviewerName;
        private System.Windows.Forms.Label greetingLabel;
    }
}