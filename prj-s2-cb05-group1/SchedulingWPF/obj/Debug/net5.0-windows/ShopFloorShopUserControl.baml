   M S B A M L   `   `   `  ����  SchedulingWPF,    &SchedulingWPF.ShopFloorShopUserControl   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $
��1200��5   7   $	��800��6G   .��5      � -   5          �Name$  MainGrid��5      $
��1200��6   $	��800��6-    � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   6,   .+�5   
   �� -   5         ��Name$ lvShelfStock��5       $��1��6   $��	10,5,5,10q�66    �� View 5      �� 5      5      5      �� 5   
   -   5         ��Name$ lblStock��5      $��Shelf Stock��6"   $
��Left=�68   $��40��6S   $��	10,10,0,5q�6_   $	��Top=�6r   $	��150��6�   $��Center=�6�   �� 5   
   -   5         ��Name$ btnCreateOrder��5      $��Create New Order��6)   $��Right=�6D   $��40��6`   $��5,10,5,5q�6l   $	��Top=�6~   $	��170��6�    J� RenderTransformOrigin$ 0.493,-0.045&�6�   6�   �� 5   
   -   5        $ btnAddProduct��5      $��Add Product��6(   $
��Left=�6>   $��40��6Y   $��5,10,5,0q�6e   $	��Top=�6w   $	��170��6�   $��1��6�   $y�Hidden=�6�   �� 5   
   -   5        $ lvMiddle��5      $��5,5,5,10q�6%   $��1��67   $��1��6G    5      �� 5      .P�5      �� 5      5!      �� 5"   
   -   5        $ btnRemoveProduct��5"      $��Remove Product��6+   $��Right=�6D   $��40��6`   $��0,10,5,5q�6l   $	��Top=�6~   $	��170��6�   $��1��6�   $y�Hidden=�6�   �� 5#   
   -   5        $ btnCompleteOrder��5#      $��Complete Order��6+   $
��Left=�6D   $��60��6_   $��5,0,0,10q�6k   $��Bottom=�6}   $	��170��6�   $��1��6�   $��1��6�   $y�Hidden=�6�   �� 5$   
   -	   5        $ btnCancelOrder��5$      $��Cancel Order��6)   $��Right=�6@   $��60��6\   $��0,0,5,10q�6h   $��Bottom=�6z   $	��170��6�   $��1��6�   $��1��6�   $y�Hidden=�6�   �� 5%   
   -
   5        $ lvOrderOverview��5%      $��2��6,   $��	5,5,10,10q�6<   $��1��6O    5&      �� 5'      .P�5(      �� 5)      5+      �� 5,   
   -   5        $ 	lblOrders��5,      $��Order Overview��6#   $��Right=�6<   $��40��6X   $��
10,10,10,5q�6d   $	��Top=�6x   $	��150��6�   $��2��6�   $��Right=�6�   $��Center=�6�   �� 5-   
   -   5        $ btnShowOrder��5-      $��
Show Order��6'   $
��Left=�6<   $��40��6W   $��5,10,5,5q�6c   $	��Top=�6u   $	��170��6�   $��2��6�   6�   �� 5.   
   -   5        $ 
lblDetails��5.      $��Order Details��6$   $��1��6<   $��Center=�6L   $��40��6i   $��5,10,5,5q�6u   $��Center=�6�   $	��150��6�   $��Center=�6�   $��Center=�6�   5/      50      