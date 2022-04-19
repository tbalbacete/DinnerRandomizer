namespace RandomizerUI
{
    partial class RandomizerDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashboardHeaderLabel = new System.Windows.Forms.Label();
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.recipeLabel = new System.Windows.Forms.Label();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.ingredientsListLabel = new System.Windows.Forms.Label();
            this.generateRandomRecipeButton = new System.Windows.Forms.Button();
            this.createNewRecipeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dashboardHeaderLabel
            // 
            this.dashboardHeaderLabel.AutoSize = true;
            this.dashboardHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashboardHeaderLabel.ForeColor = System.Drawing.Color.Brown;
            this.dashboardHeaderLabel.Location = new System.Drawing.Point(239, 54);
            this.dashboardHeaderLabel.Name = "dashboardHeaderLabel";
            this.dashboardHeaderLabel.Size = new System.Drawing.Size(386, 59);
            this.dashboardHeaderLabel.TabIndex = 0;
            this.dashboardHeaderLabel.Text = "Recipe Randomizer";
            // 
            // recipeNameTextBox
            // 
            this.recipeNameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.recipeNameTextBox.Location = new System.Drawing.Point(463, 178);
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            this.recipeNameTextBox.Size = new System.Drawing.Size(362, 47);
            this.recipeNameTextBox.TabIndex = 1;
            this.recipeNameTextBox.Text = "name of recipe";
            // 
            // recipeLabel
            // 
            this.recipeLabel.AutoSize = true;
            this.recipeLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recipeLabel.ForeColor = System.Drawing.Color.Brown;
            this.recipeLabel.Location = new System.Drawing.Point(584, 129);
            this.recipeLabel.Name = "recipeLabel";
            this.recipeLabel.Size = new System.Drawing.Size(115, 45);
            this.recipeLabel.TabIndex = 2;
            this.recipeLabel.Text = "Recipe";
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 41;
            this.ingredientsListBox.Location = new System.Drawing.Point(463, 292);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(362, 250);
            this.ingredientsListBox.TabIndex = 3;
            // 
            // ingredientsListLabel
            // 
            this.ingredientsListLabel.AutoSize = true;
            this.ingredientsListLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredientsListLabel.ForeColor = System.Drawing.Color.Brown;
            this.ingredientsListLabel.Location = new System.Drawing.Point(551, 243);
            this.ingredientsListLabel.Name = "ingredientsListLabel";
            this.ingredientsListLabel.Size = new System.Drawing.Size(183, 45);
            this.ingredientsListLabel.TabIndex = 4;
            this.ingredientsListLabel.Text = "Ingredients";
            // 
            // generateRandomRecipeButton
            // 
            this.generateRandomRecipeButton.BackColor = System.Drawing.SystemColors.Menu;
            this.generateRandomRecipeButton.Location = new System.Drawing.Point(32, 161);
            this.generateRandomRecipeButton.Name = "generateRandomRecipeButton";
            this.generateRandomRecipeButton.Size = new System.Drawing.Size(319, 81);
            this.generateRandomRecipeButton.TabIndex = 5;
            this.generateRandomRecipeButton.Text = "Find Random Recipe";
            this.generateRandomRecipeButton.UseVisualStyleBackColor = false;
            // 
            // createNewRecipeButton
            // 
            this.createNewRecipeButton.BackColor = System.Drawing.SystemColors.Menu;
            this.createNewRecipeButton.Location = new System.Drawing.Point(32, 365);
            this.createNewRecipeButton.Name = "createNewRecipeButton";
            this.createNewRecipeButton.Size = new System.Drawing.Size(319, 81);
            this.createNewRecipeButton.TabIndex = 6;
            this.createNewRecipeButton.Text = "Add New Recipe";
            this.createNewRecipeButton.UseVisualStyleBackColor = false;
            // 
            // RandomizerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(891, 545);
            this.Controls.Add(this.createNewRecipeButton);
            this.Controls.Add(this.generateRandomRecipeButton);
            this.Controls.Add(this.ingredientsListLabel);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.recipeLabel);
            this.Controls.Add(this.recipeNameTextBox);
            this.Controls.Add(this.dashboardHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RandomizerDashboard";
            this.Text = "Recipe Randomizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dashboardHeaderLabel;
        private TextBox recipeNameTextBox;
        private Label recipeLabel;
        private ListBox ingredientsListBox;
        private Label ingredientsListLabel;
        private Button generateRandomRecipeButton;
        private Button createNewRecipeButton;
    }
}