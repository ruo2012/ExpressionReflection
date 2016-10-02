ExpressionReflection
=====
Simple way to use Expression to Reflection.
This project use `Lambda Expression` simplify GetMember method.

### License
Thise project use **MIT License** (see `License.txt`)

### [Nuget](https://www.nuget.org/packages/SimpleExpressionReflection/1.0.0)
```
Install-Package SimpleExpressionReflection
```

### Get Started
```csharp
//get `Count` property's MemberInfo
typeof(List<int>)
    .GetMember<List<int>>(x => x.Count);

//get List<int> constructor
typeof(List<int>)
    .GetMember(x => new List<int>());

//get Clear method's MemberInfo(not return value method)
typeof(List<int>)
    .GetMember<List<int>>(x => x.Clear());

//get Sum method's MemberInfo(has return value method)
typeof(List<int>)
    .GetMember<List<int>>(x => x.Sum());

//other way
List<int> test = new List<int>();
test.GetMember(x => x.Count);
test.GetMember(x => new List<int>());
test.GetMember<List<int>>(x => x.Clear());
test.GetMember<List<int>>(x => x.Sum());
```