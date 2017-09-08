[TOC]

---

# Delegate

## 說明

1. An object that knows how to call a method (or a group of methods).
2. A reference to a function.

from Mosh Hamedani

## 運作

在 .NET 每一個我們透過 Delegate 關鍵字自訂的 Delegate 本質上是一個 class，其繼承自 System.MulticastDelegate，而 multicast Delegate 是繼承自 System.Delegate。

如果自訂 Delegate 只有參考到一個類別裡面的方法，則 Delegate class 裡面的屬性的 Method 跟 Target ，
Method: 代表 Delegate 指向的方法。
Target: 方法所屬的類別

如果自訂 Delegate 是參考到多個類別的方法，則屬性 target 會變成 null，多出一個 Non-Public members，裡面的 _invocationList 會有多個 object，object 屬性一樣都有 Method 跟 target。








