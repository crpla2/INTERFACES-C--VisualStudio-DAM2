   M S B A M L   `   `   `  ����C  ?GastosST, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:GastosSTGastosST  5      "    GastosST.PaginaInformeGastos   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:GastosST     5        N� Title$   GastosST - Vista de Gastos��5	      .��5      � ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��1��6      headerTextStyle#��[  6    .��6I   Inform de gastos de:5      � 5      $��10q�6	   $��1��6   $��1��6%    5      �� 5      �� 5        5"      �� 5#      $
��Auto �6   �� 5$      $
��Auto �6   �� 5%      .+�5)      �� $��0��6   $��2��6    $��0��64    �� Orientation$ 
Horizontal=�6A   .+�5*      ��   
labelStyle#��[ 6   .��60   	Nombre:69   �� 5+      #��[ 6   ��60   ��  �� XPath$ @Name��6R   5,      �� 5/      $��0��6   $��2��6    $��1��64   $ 
Horizontal=�6A   .+�50      �� #��[ 6   .��60   Departamento:6?   �� 51      #��[ 6   ��60   �� $ @Department��6X   52      � 54      $��0��6
   $��2��6   $��2��6.   $	��Top=�6;   $
��Left=�55      .+�57      &   System.Windows.Controls.DataGrid    columnHeaderStyle   ColumnHeaderStyle# [ 65      AutoGenerateColumns$ False��6l      RowHeaderWidth$ 0Q�6�   ��6   �� $ Expense��	   Columns	 59      4  .System.Windows.Controls.DataGridTemplateColumn  5:      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Tipo de gasto��6     typeItemTemplate   CellTemplate# [ 66     5;      $
 Cantidad��6     amountItemTemplate# [ 61   5>       � 	Resources 5@      ��%�   &	       &	 I     �� 5B      .R�5C      �� ��6   �� $ @ExpenseType��5D      �� 5F      .R�5G      �� ��6   �� $ @ExpenseAmount��5H      5I      5J      5K      5L      5M      