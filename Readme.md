ExpressionReflection
=====
簡易的使用Expression取得指定類別的MemberInfo

### 許可證
本專案使用MIT許可證

### [Nuget](https://www.nuget.org/packages/SimpleExpressionReflection/1.0.0)
```
Install-Package SimpleExpressionReflection
```

### 範例
```csharp
using ExpressionReflection;

//取得Count屬性MemberInfo
typeof(List<int>)
    .GetMember<List<int>>(x => x.Count);

//取得List<int>建構子MemberInfo
typeof(List<int>)
    .GetMember(x => new List<int>());

//取得Clear方法MemberInfo
typeof(List<int>)
    .GetMember<List<int>>(x => x.Clear())

//取得Sum方法MemberInfo
typeof(List<int>)
    .GetMember<List<int>>(x => x.Sum())

List<int> test = new List<int>();
test.GetMember(x => x.Count);
test.GetMember(x => new List<int>());
test.GetMember<List<int>>(x => x.Clear());
test.GetMember<List<int>>(x => x.Sum());
```
