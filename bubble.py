b=input().split()
money=int(b[-1])
c=input()
d=c.split()
a=sorted([int(x) for x in d])
for i in range(len(a)):
        money-=a[i]
        if money<0:
                toys=i
                break
print (toys)