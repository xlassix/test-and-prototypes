from sortedcontainers import SortedDict
from collections import OrderedDict
a= int(input())
name,score=[],[]
for _ in range(a):
    c=input().split()
    name.append(c[0])
    score.append(int(c[1]))
y=dict(zip(name,score))
z=SortedDict(y)
main=OrderedDict(sorted(z.items(),key=lambda t: t[1],reverse=True))
for i in main:
    print(i,z[i])
    z.pop(i)