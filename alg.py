def take_in(num): return [float(input()) for _ in range(num)] 
sample=int(input())
x=int(input())
instance=take_in(x)
y=int(input())
prices=take_in(y)
def interpolate(instance,prices,sample):
    try:
        position=instance.index(list(filter(lambda x:x>sample,instance))[0])
    except:
        position= len(instance)-1
    if position<1:
        xs=instance[0:2]
        ys=prices[0:2]
    else:
        xs=instance[position-1:position+1]
        ys=prices[position-1:position+1]
    ans=((ys[1]-ys[0])*(sample-xs[1])/(xs[1]-xs[0]) +ys[1])*100
    #round and format failed to approx 6.125 to 6.13
    print(ans)
    return (ans//1)/100 if ans%1 <0.5 else  ((ans+1)//1)/100
print(interpolate(instance,prices,sample))
