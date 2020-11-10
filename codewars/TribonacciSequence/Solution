//Solution in Python for "Tribonacci sequence" Kata (Kyu 6) from https://www.codewars.com/kata/556deca17c58da83c00002db

def tribonacci(signature, n):
    signature=signature[:n]
    while n-3>0:
        signature.append(sum(signature[-3:]))
        n-=1
    return signature
