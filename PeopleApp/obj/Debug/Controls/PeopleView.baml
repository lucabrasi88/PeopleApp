   M S B A M L   `   `   `  ����D  @PeopleApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:PeopleApp.ViewModelPeopleApp.ViewModel  5      ;"clr-namespace:PeopleApp.ValidationPeopleApp.Validation  5      #    PeopleApp.Controls.PeopleView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7	viewModel!clr-namespace:PeopleApp.ViewModel     5      9
validation"clr-namespace:PeopleApp.Validation     5        � 	Resources  5
         peopleDG S� 
ObjectType-   'PeopleApp.ViewModel.PeopleDataViewModel  RowStyle �� 
TargetType)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value �� Property �� Value �� RelativeSource	 �� Path��%A  &	        &	      S� 5   
   "  6/   �� 5   
   "  6!    5      P� 5       �@=�HasError . . �5      ��  � ��$ 1q�68   �� 5       � ��
 �  ��64   �� 5       �@�ToolTip 5      ��  �� *Self+$)	 #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      � 
 � DataContext#
 [  6   .+�5   
   �� .+�5      �� ��6   �� *Title+&   System.Windows.Controls.DataGrid  5      -   5          Name$ PeopleDataGrid��5   �      RowStyle# [ 6^      AutoGenerateColumns .     CanUserAddRows . ��6   ��  �� Source# [  $	 Persons�   RowValidationRules 5      4   .PeopleApp.Validation.RowDataInfoValidationRule  5      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ UpdatedValue=�6;      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First name��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *	FirstName+ �� ValidatesOnDataErrors .   5#      $ 	Last name��6)    6<   �� *
LastName+ .   5$      $ Street name��6)    6>   �� *
StreetName+ .   5%      $ House number��6)    6@   �� *HouseNumber+ .   5&      $ Apartment number��6)    6C   �� *ApartmentNumber+  5'      $ Postal code��6)    6>   �� *
PostalCode+ .   5(      $ Phone number��6)    6@   �� *PhoneNumber+ . 4	  .System.Windows.Controls.DataGridTemplateColumn	  5)      $ Day of birth��6-    	  CellTemplate 5*      �� 5+      .R�5,   "   �� ��6,   �� *
DayOfBirth+ .  �� StringFormat$ d��5-       	  CellEditingTemplate 5/      �� 50      .R�51   "   (
  "System.Windows.Controls.DatePicker
  -   5         
  SelectedDate 51   -   �� *
DayOfBirth+6Q   52      54        55      $	 Age��6)      
IsReadOnly .  66   �� *Age+6N   57      �� 58      -   5        $
��Save��58      $��25��6$   $	��100��60   $��100,0q�6N   �� 59      $��Cancel��6   $��25��6&   $	��100��62   $��100,0q�6�   ��6>   �� *RestoreCommand+# [  6�   5:      5;      5<      