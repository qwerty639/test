   M S B A M L   `   `   `  ����A  =qwerty, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:qwerty.Views.Pagesqwerty.Views.Pages  5      !    qwerty.Views.Pages.GridPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:qwerty.Views.Pages     5      -   5          N� Title$  GridPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ BtnAdd��5      .��6:   Добавить6D   �� 5      -   5        $ 	BtnDelete��5      .��6@   Удалить6I   �� 5      -   5        $ BtnEdit��5      .��6<   Редактировать6K   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dbView��5      $��1��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         AutoGenerateColumns .     
IsReadOnly .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Width$	 * 6%   
   Header$
 Курс��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *COURSE.Title+  5      $
 Тренер��6%    65   �� *TRAINER.Name+  5      $
 Дата начала��6%    6:   �� *CreatedDate+  5      $
 Балл��6%    63   �� *
TotalPoint+  5      $
 Завершен��6%    67   �� *IsDone+  5       $
 Комментарий��6%    6:   �� *	Comment+5&      5(      5)      