   M S B A M L   `   `   `  ����J  FWpfAppFitipaldi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfAppFitipaldiWpfAppFitipaldi  5   	   )    #WpfAppFitipaldi.NuevoVehiculoWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfAppFitipaldi     5   	     � Title$  NuevoVehiculoWindow��5   	   $	��450��6%   $	��800��62   .��5	      � $��20,20,20,20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Marca:��6-   $��0,10,0,0q�6>   �� 5   
   -   5         ��Name$ MarcaTextBox��5   /   $��0��6   $��1��6   $��	10,10,0,0q�6E   �� 5   
   $��1��6   $��0��6   $��Modelo:��6-   $��0,10,0,0q�6?   �� 5   
   -   5        $ ModeloTextBox��5   /   $��1��6   $��1��6   $��	10,10,0,0q�6F   �� 5   
   $��2��6   $��0��6   $��Matrícula:��6-   $��0,10,0,0q�6B   �� 5   
   -   5        $ MatriculaTextBox��5   /   $��2��6   $��1��6   $��	10,10,0,0q�6I   �� 5    
   $��3��6   $��0��6   $��Cliente:��6-   $��0,10,0,0q�6@   �� 5!   
   -   5         ��Name$ ClientesComboBox��5!   0   $��3��6   $��1��6    $��	10,10,0,0q�6J   �� 5#   
   $��4��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��	0,20,10,0q�6g   .+�5$      �� -   5         ��Name$ guardarButton��5$      $��Guardar��6,   $��0,0,10,0q�6>   6P   �� 5%      -   5        $ cancelarButton��5%      $��Cancelar��6-   6@   5&      5'      5(      