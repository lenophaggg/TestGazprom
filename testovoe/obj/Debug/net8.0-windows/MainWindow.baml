   M S B A M L   `   `   `  ����  testovoe    testovoe.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��892��6)   .��5      �  � RowDefinitions 5   
   �� 5	      $��* �6   �� 5
      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��3* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridObjects��5      $��0��5      $��0��6       AutoGenerateColumns$ False��5         CanUserAddRows$ False��5         CanUserDeleteRows$
 True��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5   %   �� *Name+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  5      $ X (м)��6%   	 5   %   �� *XCoordinate+$
 TwoWay=�$ PropertyChanged=�  5       $ Y (ч)��6%   	 5!   %   �� *YCoordinate+$
 TwoWay=�$ PropertyChanged=�  5#      $ Ширина (м)��6%   	 5$   %   �� *Width+$
 TwoWay=�$ PropertyChanged=�  5&      $ Высота (ч)��6%   	 5'   %   �� *Height+$
 TwoWay=�$ PropertyChanged=�4  .System.Windows.Controls.DataGridCheckBoxColumn  5)      $ Дефект��6)   	 5*   )   �� *
IsDefect+$
 TwoWay=�$ PropertyChanged=�5.      � 50   
   $��0��6   $��1��6   $��10q�6,    51      �� 52      $
��Auto �6    �� 53      $��* �6    .+�56      �� $��0��6   .+�58      �� $!��Детали объекта��6   $
��Bold"�62   $��14(�6D   $��0,0,0,10q�6R   �� 5:      �� 5;      $�Название: ��6    �� 5<      �6   �� *SelectedItem.Name+ �� ElementName$ DataGridObjects��5=      �� 5?      �� 5@      $�Координата X: ��6    �� 5A      �6   �� *SelectedItem.XCoordinate+$ DataGridObjects��5B      �� 5D      �� 5E      $�Координата Y: ��6    �� 5F      �6   �� *SelectedItem.YCoordinate+$ DataGridObjects��5G      �� 5I      �� 5J      $�Ширина: ��6    �� 5K      �6   �� *SelectedItem.Width+$ DataGridObjects��5L      �� 5N      �� 5O      $�Высота: ��6    �� 5P      �6   �� *SelectedItem.Height+$ DataGridObjects��5Q      �� 5S      �� 5T      $�Дефект: ��6    �� 5U      �6   �� *SelectedItem.IsDefect+$ DataGridObjects��5V      5X      �� 5Z      -   5         ��Name$ 
CanvasArea��5Z      $��1��5[      
�������5\      5]      �� 5_   
   $��1��6   $��0��6"   $��2��62    �� Orientation$ 
Horizontal=�5`      $��Right=�5a      $��10q�5b      .+�5d      �� -   5        $$��Импортировать CSV��5d      $��0,0,10,0q�6I   $
��10,4q�6[   �� 5f      -   5        $&�� Импортировать Excel��5f      $
��10,4q�6M   5h      5i      5j      