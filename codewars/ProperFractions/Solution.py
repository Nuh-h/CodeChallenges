#Solution for 'Number of Proper Fractions with Denominator d' Kata (4kyu) at https://www.codewars.com/kata/55b7bb74a0256d4467000070
#Credit to Alex at Alexwlchan.net that wrote much of these functions,
#I only modified it to suit this problem
import collections

def prime_factors(n):
    i = 2
    while i * i <= n:
        if n % i == 0:
            n = int(n/i)
            yield i
        else:
            i += 1

    if n > 1:
        yield n

def proper_fractions(n):
    if n==1: return 0
    pf = prime_factors(n)
    pf_with_multiplicity = collections.Counter(pf)
    factCount = [(factor,count) for factor,count in pf_with_multiplicity.items()]
    print(factCount)
    count=1
    for r in factCount:
        count*=(r[0]**(r[1]-1))*(r[0]-1) #Euler's totient formula
    return count    
