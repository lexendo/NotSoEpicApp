   M S B A M L   `   `   `  ����G  CNotSoEpicApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:NotSoEpicAppNotSoEpicApp  5          NotSoEpicApp.Charts   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:NotSoEpicApp     5        N� Title$  Charts��5	       N� 
Background 5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ #B3E5FC��6    � Offset$	 0.0Q�6+   � 5      $ #CFD8DC��6   $	 1.0Q�6+   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��219* �6   �� 5      $
��130* �6   �� 5      $
��Auto �6   $��75��6*    � ColumnDefinitions 5   
   �� 5      �� 5      $	��275 �6   .+�5!   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��	10,0,10,0q�6>   $��Center=�6Q   $��26��6l   .+�5"      �� $��Select time period:��6   $��Center=�62   $��0,0,10,0q�6M   �� 5#      -   5        	 ��Name$	 Time_Range_Box��5#      $	��200��6/   $��Center=�6;   .@�5$      �� $��
Last Month��6   �� 5%      $��Last Quarter��6   �� 5&      $��	Last Year��6   5'      5(      �� 5*   
   $��Income vs Expenses��6   $��18(�6-   $
��Bold"�6;   $��1��6M   $��Center=�6Z   $	��328��6w   $��Center=�6�   $��2��6�   $	��182��6�   �� 5,   
   -   5        
 ��Name$
 PieChartCanvas��5,      $��1��6)   $��Center=�66   $��Center=�6Q   $	��310��6n   $	��242��6z    J� RenderTransformOrigin$ 	0.5,0.633&�6�   $��2��6�   �� 5.   
   $��1��6   $��1��6"   $	��Top=�62   $��	0,10,10,0q�6J   $	��100��6]   .+�5/      �� -   5         ��Name$ IncomeTextBlock��5/      $��16(�61   $
��Bold"�6?   
��� � �$
��0,10q�6d   $��34��6r   �� 50      -   5        $ ExpensesTextBlock��50      $��16(�63   $
��Bold"�6A   
���  ��$
��0,10q�6d   $��33��6r   51      �� 53   
   -   5        $
��Home��53      $��3��6    $��1��6-   $��46��6=   $��	12,0,12,0q�6I   $��Center=�6\   6w   54      55      