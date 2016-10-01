ExpressionReflection
=====
²�����ϥ�Expression���o���w���O��MemberInfo

### �\�i��
���M�רϥ�MIT�\�i��

### �d��
```csharp
//���oCount�ݩ�MemberInfo
typeof(List<int>)
    .GetMember<List<int>>(x => x.Count);

//���oList<int>�غc�lMemberInfo
typeof(List<int>)
    .GetMember(x => new List<int>());

//���oClear��kMemberInfo
typeof(List<int>)
    .GetMember<List<int>>(x => x.Clear())

//���oSum��kMemberInfo
typeof(List<int>)
    .GetMember<List<int>>(x => x.Sum())

List<int> test = new List<int>();
test.GetMember(x => x.Count);
test.GetMember(x => new List<int>());
test.GetMember<List<int>>(x => x.Clear());
test.GetMember<List<int>>(x => x.Sum());
```