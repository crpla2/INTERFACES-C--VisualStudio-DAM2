   M S B A M L   `   `   `  ����J  FWpfAppFitipaldi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfAppFitipaldiWpfAppFitipaldi  5      "    WpfAppFitipaldi.PageClientes   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6.   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      )localclr-namespace:WpfAppFitipaldi  5        N� Title$  Page1��5       N� 
Background 5      �� 5   
    �� ImageSource$ /img/fondo.jpg��6    � 	Resources 5       �� 
TargetType �� Property �� Value��%z   '��       �� 5   
   " ��6   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��
 ��  �6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Clientes��6   $��Center=�6$   $��30(�6A   $
��Bold"�6O   $��13,2,2,0q�6a   �� 5   
   $��Clientes��6   $��Center=�6$   $��30(�6A   $
��Bold"�6O   $��5,0,0,0q�6a   
���k���6r   �� 5   
   -   5         ��Name$ formularioClientes��5      $��1��61   $��Center=�6>   $��10,0,0,0q�6[   $	��Top=�6m   $	��400��6�   
�������.+�5      �� 	 �� Orientation$	 
Horizontal=�6   $��	120,0,0,8q�62   .+�5       �� -   5        
 ��Name$
 clientesComboBox��5       $
��Left=�66   $��10,5,0,0q�6Q   $	��Top=�6c   $	��200��6{    �� DisplayMemberPath$ Nombre��6�   6�   5!      �� 5"      $	 
Horizontal=�6   $��30,0,0,8q�62   .+�5#      �� $��Nombre:��6   $	��100��6+   $
��Bold"�67   �� 5$      -   5         ��Name$ nombreTextBox��5$       �� TextWrapping$
 Wrap=�61   $	��200��6�   ��6E   �� *SelectedItem.Nombre+ �� ElementName$ clientesComboBox�� �� Mode$ TwoWay=�6�   5%      �� 5&      $	 
Horizontal=�6   $��30,0,0,8q�62   .+�5'      �� $��
Apellidos:��6   $	��100��6.   $
��Bold"�6:   �� 5(      -   5        $ apellidosTextBox��5(      $
 Wrap=�64   $	��200��6�   ��6H   �� *SelectedItem.Apellidos+$ clientesComboBox��$ TwoWay=�6�   5)      �� 5*      $	 
Horizontal=�6   $��30,0,0,8q�62   .+�5+      �� $��Dirección:��6   $	��100��6.   $
��Bold"�6:   �� 5,      -   5        $ direccionTextBox��5,      $
 Wrap=�64   $	��200��6�   ��6H   �� *SelectedItem.Direccion+$ clientesComboBox��$ TwoWay=�6�   5-      �� 5.      $	 
Horizontal=�6   $��30,0,0,8q�62   .+�5/      �� $��
Teléfono:��6   $	��100��6-   $
��Bold"�69   �� 50      -   5        $ telefonoTextBox��50      $
 Wrap=�63   $	��200��6�   ��6G   �� *SelectedItem.Telefono+$ clientesComboBox��$ TwoWay=�6�   51      �� 52      $	 
Horizontal=�6   $��30,0,0,5q�62   .+�53      �� $
��DNI:��6   $	��100��6(   $
��Bold"�64   �� 54      -   5        $ 
dniTextBox��54      $
 Wrap=�6.   $	��200��6�   ��6B   �� *SelectedItem.Dni+$ clientesComboBox��$ TwoWay=�6�   55      �� 56      $	 
Horizontal=�6   .+�57      �� -   5         ��Name$ insertarButton��57      $��Insertar��61   $��	40,8,10,0q�6D   $	��100��6W   6c   �� 58      -	   5        $ actualizarButton��58      $��
Actualizar��63   $��0,8,10,0q�6H   $	��100��6Z   6f   �� 59      -
   5        $ borrarButton��59      $��Borrar��6/   $��0,8,10,0q�6@   $	��100��6R   6^   5:      �� 5;      $	 
Horizontal=�6   $��Center=�62   $	��Top=�6P   $	��400��6h   .+�5<      �� -   5        $ limpiarButton��5<      $��Limpiar Datos��60   $��
150,8,10,5q�6H   $	��100��6\   6h   5=      5>      �� 5?   
   $
��Left=�6   $	��139��6+   $��	31,44,0,0q�68   $��1��6K   $	��Top=�6X   $	��139��6p   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ /img/putin.gif��6}   �� 5@   
   $
��Left=�6   $	��139��6+   $��
624,44,0,0q�68   $��1��6L   $	��Top=�6Y   $	��139��6q   $ /img/alonso.gif��6~   5B      5D      