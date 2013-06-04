
// This file has been generated by the GUI designer. Do not modify.
namespace earchive
{
	public partial class DocsType
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action recognizeAction;
		private global::Gtk.Action openAction;
		private global::Gtk.Action saveAsAction;
		private global::Gtk.Action clearAction;
		private global::Gtk.Table table1;
		private global::Gtk.Entry entryID;
		private global::Gtk.Entry entryName;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment6;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label labelTemplateName;
		private global::Gtk.Toolbar toolbar1;
		private global::Gtk.Label GtkLabel6;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView textviewDescription;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label5;
		private global::Gtk.Entry entryDBTable;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Label label6;
		private global::Gtk.Label label4;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewFields;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Button buttonAdd;
		private global::Gtk.Button buttonEdit;
		private global::Gtk.Button buttonDelete;
		private global::Gtk.Button buttonApply;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget earchive.DocsType
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.recognizeAction = new global::Gtk.Action ("recognizeAction", null, null, "recognize");
			w1.Add (this.recognizeAction, null);
			this.openAction = new global::Gtk.Action ("openAction", null, null, "gtk-open");
			w1.Add (this.openAction, null);
			this.saveAsAction = new global::Gtk.Action ("saveAsAction", null, null, "gtk-save-as");
			w1.Add (this.saveAsAction, null);
			this.clearAction = new global::Gtk.Action ("clearAction", null, null, "gtk-clear");
			w1.Add (this.clearAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "earchive.DocsType";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child earchive.DocsType.VBox
			global::Gtk.VBox w2 = this.VBox;
			w2.Name = "dialog1_VBox";
			w2.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.entryID = new global::Gtk.Entry ();
			this.entryID.Sensitive = false;
			this.entryID.CanFocus = true;
			this.entryID.Name = "entryID";
			this.entryID.IsEditable = true;
			this.entryID.InvisibleChar = '●';
			this.table1.Add (this.entryID);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryID]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.table1.Add (this.entryName);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryName]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment6 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment6.Name = "GtkAlignment6";
			this.GtkAlignment6.LeftPadding = ((uint)(12));
			// Container child GtkAlignment6.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelTemplateName = new global::Gtk.Label ();
			this.labelTemplateName.Name = "labelTemplateName";
			this.labelTemplateName.LabelProp = global::Mono.Unix.Catalog.GetString ("Отсутствует");
			this.labelTemplateName.Wrap = true;
			this.vbox2.Add (this.labelTemplateName);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelTemplateName]));
			w5.Position = 0;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='recognizeAction' action='recognizeAction'/><toolitem name='openAction' action='openAction'/><toolitem name='saveAsAction' action='saveAsAction'/><toolitem name='clearAction' action='clearAction'/></toolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.toolbar1.ToolbarStyle = ((global::Gtk.ToolbarStyle)(0));
			this.toolbar1.IconSize = ((global::Gtk.IconSize)(4));
			this.vbox2.Add (this.toolbar1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.toolbar1]));
			w6.Position = 1;
			w6.Fill = false;
			this.GtkAlignment6.Add (this.vbox2);
			this.frame1.Add (this.GtkAlignment6);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Шаблон распознования</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel6;
			this.table1.Add (this.frame1);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.frame1]));
			w9.BottomAttach = ((uint)(3));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.textviewDescription = new global::Gtk.TextView ();
			this.textviewDescription.CanFocus = true;
			this.textviewDescription.Name = "textviewDescription";
			this.textviewDescription.WrapMode = ((global::Gtk.WrapMode)(2));
			this.GtkScrolledWindow1.Add (this.textviewDescription);
			this.table1.Add (this.GtkScrolledWindow1);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkScrolledWindow1]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(3));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>extra_</b>");
			this.label5.UseMarkup = true;
			this.hbox2.Add (this.label5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label5]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entryDBTable = new global::Gtk.Entry ();
			this.entryDBTable.CanFocus = true;
			this.entryDBTable.Name = "entryDBTable";
			this.entryDBTable.IsEditable = true;
			this.entryDBTable.MaxLength = 10;
			this.entryDBTable.InvisibleChar = '●';
			this.hbox2.Add (this.entryDBTable);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entryDBTable]));
			w13.Position = 1;
			this.table1.Add (this.hbox2);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox2]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Код:");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Название<span foreground=\"red\">*</span>:");
			this.label2.UseMarkup = true;
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Имя таблицы БД:");
			this.label3.UseMarkup = true;
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.Yalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Описание:");
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			w2.Add (this.table1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(w2 [this.table1]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Дополнительные поля документа</b>");
			this.label4.UseMarkup = true;
			w2.Add (this.label4);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(w2 [this.label4]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow.BorderWidth = ((uint)(3));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewFields = new global::Gtk.TreeView ();
			this.treeviewFields.CanFocus = true;
			this.treeviewFields.Name = "treeviewFields";
			this.GtkScrolledWindow.Add (this.treeviewFields);
			w2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(w2 [this.GtkScrolledWindow]));
			w22.Position = 2;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(3));
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonAdd = new global::Gtk.Button ();
			this.buttonAdd.Sensitive = false;
			this.buttonAdd.CanFocus = true;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.UseUnderline = true;
			// Container child buttonAdd.Gtk.Container+ContainerChild
			global::Gtk.Alignment w23 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w24 = new global::Gtk.HBox ();
			w24.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w25 = new global::Gtk.Image ();
			w25.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w24.Add (w25);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w27 = new global::Gtk.Label ();
			w27.LabelProp = global::Mono.Unix.Catalog.GetString ("Добавить");
			w27.UseUnderline = true;
			w24.Add (w27);
			w23.Add (w24);
			this.buttonAdd.Add (w23);
			this.hbox1.Add (this.buttonAdd);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonAdd]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonEdit = new global::Gtk.Button ();
			this.buttonEdit.Sensitive = false;
			this.buttonEdit.CanFocus = true;
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.UseUnderline = true;
			// Container child buttonEdit.Gtk.Container+ContainerChild
			global::Gtk.Alignment w32 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w33 = new global::Gtk.HBox ();
			w33.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w34 = new global::Gtk.Image ();
			w34.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w33.Add (w34);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w36 = new global::Gtk.Label ();
			w36.LabelProp = global::Mono.Unix.Catalog.GetString ("Изменить");
			w36.UseUnderline = true;
			w33.Add (w36);
			w32.Add (w33);
			this.buttonEdit.Add (w32);
			this.hbox1.Add (this.buttonEdit);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonEdit]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonDelete = new global::Gtk.Button ();
			this.buttonDelete.Sensitive = false;
			this.buttonDelete.CanFocus = true;
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.UseUnderline = true;
			// Container child buttonDelete.Gtk.Container+ContainerChild
			global::Gtk.Alignment w41 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w42 = new global::Gtk.HBox ();
			w42.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w43 = new global::Gtk.Image ();
			w43.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-remove", global::Gtk.IconSize.Menu);
			w42.Add (w43);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w45 = new global::Gtk.Label ();
			w45.LabelProp = global::Mono.Unix.Catalog.GetString ("Удалить");
			w45.UseUnderline = true;
			w42.Add (w45);
			w41.Add (w42);
			this.buttonDelete.Add (w41);
			this.hbox1.Add (this.buttonDelete);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonDelete]));
			w49.Position = 2;
			w49.Expand = false;
			w49.Fill = false;
			w2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(w2 [this.hbox1]));
			w50.Position = 3;
			w50.Expand = false;
			w50.Fill = false;
			// Internal child earchive.DocsType.ActionArea
			global::Gtk.HButtonBox w51 = this.ActionArea;
			w51.Name = "dialog1_ActionArea";
			w51.Spacing = 10;
			w51.BorderWidth = ((uint)(5));
			w51.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonApply = new global::Gtk.Button ();
			this.buttonApply.Sensitive = false;
			this.buttonApply.CanFocus = true;
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.UseUnderline = true;
			// Container child buttonApply.Gtk.Container+ContainerChild
			global::Gtk.Alignment w52 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w53 = new global::Gtk.HBox ();
			w53.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w54 = new global::Gtk.Image ();
			w54.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w53.Add (w54);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w56 = new global::Gtk.Label ();
			w56.LabelProp = global::Mono.Unix.Catalog.GetString ("Применить");
			w56.UseUnderline = true;
			w53.Add (w56);
			w52.Add (w53);
			this.buttonApply.Add (w52);
			w51.Add (this.buttonApply);
			global::Gtk.ButtonBox.ButtonBoxChild w60 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w51 [this.buttonApply]));
			w60.Expand = false;
			w60.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w61 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w62 = new global::Gtk.HBox ();
			w62.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w63 = new global::Gtk.Image ();
			w63.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w62.Add (w63);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w65 = new global::Gtk.Label ();
			w65.LabelProp = global::Mono.Unix.Catalog.GetString ("О_тменить");
			w65.UseUnderline = true;
			w62.Add (w65);
			w61.Add (w62);
			this.buttonCancel.Add (w61);
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w69 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w51 [this.buttonCancel]));
			w69.Position = 1;
			w69.Expand = false;
			w69.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.Sensitive = false;
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			// Container child buttonOk.Gtk.Container+ContainerChild
			global::Gtk.Alignment w70 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w71 = new global::Gtk.HBox ();
			w71.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w72 = new global::Gtk.Image ();
			w72.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Menu);
			w71.Add (w72);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w74 = new global::Gtk.Label ();
			w74.LabelProp = global::Mono.Unix.Catalog.GetString ("_OK");
			w74.UseUnderline = true;
			w71.Add (w74);
			w70.Add (w71);
			this.buttonOk.Add (w70);
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w78 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w51 [this.buttonOk]));
			w78.Position = 2;
			w78.Expand = false;
			w78.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 669;
			this.DefaultHeight = 400;
			this.Show ();
			this.recognizeAction.Activated += new global::System.EventHandler (this.OnRecognizeActionActivated);
			this.openAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
			this.saveAsAction.Activated += new global::System.EventHandler (this.OnSaveAsActionActivated);
			this.clearAction.Activated += new global::System.EventHandler (this.OnClearActionActivated);
			this.entryDBTable.Changed += new global::System.EventHandler (this.OnEntryDBTableChanged);
			this.entryName.Changed += new global::System.EventHandler (this.OnEntryNameChanged);
			this.treeviewFields.CursorChanged += new global::System.EventHandler (this.OnTreeviewFieldsCursorChanged);
			this.treeviewFields.RowActivated += new global::Gtk.RowActivatedHandler (this.OnTreeviewFieldsRowActivated);
			this.buttonAdd.Clicked += new global::System.EventHandler (this.OnButtonAddClicked);
			this.buttonEdit.Clicked += new global::System.EventHandler (this.OnButtonEditClicked);
			this.buttonDelete.Clicked += new global::System.EventHandler (this.OnButtonDeleteClicked);
			this.buttonApply.Clicked += new global::System.EventHandler (this.OnButtonApplyClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
