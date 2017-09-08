[TOC]

---

# Delegate

## 說明

1. An object that knows how to call a method (or a group of methods).
2. A reference to a function.

from Mosh Hamedani

## hy do wo need delegates?

For designing extensible and flexible applications (eg frameworks)

## 使用
1. 定義委派

    delegate void/回傳型別 MyDelegate(方法簽章) 

2. 委派方法s

3. 透過委派執行方法

## 運作

在 .NET 每一個我們透過 Delegate 關鍵字自訂的 Delegate ，本質上是一個 class，其繼承自 System.MulticastDelegate，而 multicast Delegate 是繼承自 System.Delegate。

如果自訂 Delegate 只有參考到一個類別裡面的方法，則 Delegate class 裡面的屬性的 Method 跟 Target ，
Method: 代表 Delegate 指向的方法。
Target: 方法所屬的類別

如果自訂 Delegate 是參考到多個類別的方法，則屬性 target 會變成 null，多出一個 Non-Public members，裡面的 _invocationList 會有多個 object，object 屬性一樣都有 Method 跟 target。

## .NET 定義的委派

在 .NET 在 generic 有定義好兩種 Delegate，因此可以先考慮使用 .NET 的不用先自己定義。

```c#
// 可委派沒有回傳值的方法，可傳入參數數 1～16 個
  System.Action<in T>
  System.Action<in T, ... ,in T16>
// 可委派有一個回傳值的方法，可傳入參數數 0～16 個
  System.Func<out TResult>
  System.Func<in T, out TResult>
  System.Func<in T, ... , in T16, out TResult>
```



## 替代方案 Interfaces

### Interfaces or Delegates?

Use a delegate when

- An eventing design pattern is used.
- The caller doesn't need to access other properties or methods on the object implementing the method.




