   M S B A M L   `   `   `  ����G  CNotSoEpicApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:NotSoEpicAppNotSoEpicApp  5          NotSoEpicApp.Transactions   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:NotSoEpicApp     5        N� Title$  Transactions��5      $	��450��6   $	��800��6)    N� 
Background 5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ #B3E5FC��6    � Offset$	 0.0Q�6+   � 5      $ #CFD8DC��6   $	 1.0Q�6+   5      .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      �� 5      $��0 �6   �� 5      $	��285 �6   .+�5   
   �� -   5         ��Name$ TransactionsListBox��5      $��14(�6/   
���   ���5      �� 5      .R�5      ��  ��Name$ BorderElement��6   	 �� Padding$	 5q�64   $��2q�6@   ._�5       �� 
 �� Orientation$
 
Horizontal=�6%   .+�5!      �� $	��200��6?   ��6(   �� *Title+6?   �� 5"      $	��100��6Z    �� TextAlignment$ Right=�6f   ��6(   �� *Amount+ �� StringFormat$ 	{0:$0.00}��6f   �� 5#      $	��150��6]   $ Right=�6i   ��6(   �� *Date+$ {0:MM/dd/yyyy}��6i   5$      5%       �� Triggers 5&      �� 5'       �� Value$
 True��6C    �� Binding 6&   �� *
IsIncome+.a�5(      ��  �� 
TargetName$ BorderElement��6%    �� Property � �� �� Value
 ����6V   5)      �� 5*      $ False��6C    6&   �� *
IsIncome+.a�5+      �� $ BorderElement��6%    � ��
 �����6V   5,      5.      50      �� 52   
   $��2��6   $��
0,10,10,10q�6%   .+�53      �� -   5         ��Name$ DescriptionTextBlock��53      $2��,Select a transaction to see the description.��66   $
��Wrap=�6j   $��16(�6~   $	��300��6�   $	��267��6�   �� 54      -   5        $
��Home��54      $	��126��6C   $��45��6O   55      56      57      