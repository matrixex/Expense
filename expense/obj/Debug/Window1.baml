   M S B A M L   `   `   `  ����B  >expense, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:expenseexpense  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      !clr-namespace:expenseexpense  5	   	       expense.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:expense     5   	   7core&clr-namespace:System;assembly=mscorlib     5      ,
staticDataclr-namespace:expense     5	   	     � Title$  查看数据��5   	   $	��472��6   $	��624��6#    � 	Resources 5        expense.ExpenseCategory   ExpenseCategory��%   &	          5   
   6&   5      .��5      � $
��Left=�6   $	��604��6&   $��0,10,0,0q�62   $	��417��6D   $	��Top=�6Q   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dg��5      $	��316��6   $��39,86,32,15q�6,      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        id_text��,  &System.Windows.Controls.DataGridColumn   Header$ ID��5   7      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   ��  �� Path$ id�	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 时间��6)   $ 80 65      CellTemplate 5      �� 5      .R�5      �� ��6)   �� $ 时间�$	 TwoWay=�$
 PropertyChanged=� �� StringFormat$ {0:yyyy/M/d}��5         CellEditingTemplate 5      �� 5       .R�5#      (  "System.Windows.Controls.DatePicker     SelectedDate 6+   �� $ 时间�5$      5(        5*      -   5        Describe��$ 描述��5*   8   $	 260 6D    6Q   �� $ 描述�$	 TwoWay=�$
 PropertyChanged=�  5+      $ 类别��6)   $ 80 65    5,      �� 5-      .R�5.      �� ��6(   �� $ 类别�$	 TwoWay=�$
 PropertyChanged=�5/       51      �� 52      .R�55      �� #��[  6A    �� Text 6(   �� $ 类别�6A   56      5:        5=      $ 金额��6'   $ 50 63    6?   �� $ 金额�$	 TwoWay=�$
 PropertyChanged=�5D      �� 5E   
   -   5        $��查询��5E      $
��Left=�6   $��	55,30,0,0q�69   $	��Top=�6L   $��75��6d   6o   �� 5F   
   -   5         ��Name$	 cmb��5F      $
��Left=�6    $��
180,30,0,0q�6;   $	��Top=�6O   $	��120��6g   �� 5G   
   -   5        $��返回��5G      $
��Left=�6   $��
473,30,0,0q�69   $	��Top=�6M   $��75��6e   6p   �� 5H   
   -   5        $��提交修改��5H      $
��Left=�6    $��
357,30,0,0q�6;   $	��Top=�6O   $��75��6g   6r   5J      5K      