   M S B A M L   `   `   `  ����  WpfAppGASTOS!    ExpenseIt.ExpenseReportPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  ExpenseIt - View Expense��5      .��5
      � ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��1��6      headerTextStyle#��[  6    .��6I   Relación de gastos de:5      � 5   
   $��10q�6   $��1��6   $��1��6+    5      �� 5      �� 5       5!      �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      .+�5(      �� $��0��6   $��2��6)   $��0��6=    �� Orientation$ 
Horizontal=�6J   .+�5)      ��   
labelStyle#��[ 6   .��6<   	Nombre:6E   �� 5*      #��[ 6   ��6<   ��  �� XPath$ @Name��6^   5+      �� 5.      $��0��6   $��2��6)   $��1��6=   $ 
Horizontal=�6J   .+�5/      �� #��[ 6   .��6<   Departmento:6J   �� 50      #��[ 6   ��6<   �� $ @Department��6d   51      � 53      $��0��6   $��2��6#   $��2��67   $	��Top=�6D   $
��Left=�54       � 	Resources 56        typeItemTemplate  amountItemTemplate��%�   &	       &	 I     �� 58      .R�59      �� ��6    �� $ @ExpenseType��5:      �� 5<      .R�5=      �� ��6    �� $ @ExpenseAmount��5>      5?      .+�5A      &   System.Windows.Controls.DataGrid    columnHeaderStyle   ColumnHeaderStyle# [ 6A      AutoGenerateColumns$ False��6x   	   RowHeaderWidth$	 0Q�6�   ��6   �� $ Expense��
   Columns
 5C      4  .System.Windows.Controls.DataGridTemplateColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$ Gasto��61      CellTemplate# [ 6@     5E      $ Cantidad��61   # [ 6C   5H      5I      5J      5L      5M      