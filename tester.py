def int_to_reverse_binary(integer_value):
    reverse_binary = ''
    while integer_value > 0:
        reverse_binary += str(integer_value % 2)
        integer_value = integer_value // 2
    return reverse_binary[::-1]
    
def string_reverse(input_string):
    reverse_binary = ''
    while integer_value > 0:
        reverse_binary += str(integer_value % 2)
        integer_value = integer_value // 2
    return reverse_binary[::-1]

if __name__ == '__main__':
    input_num = int(input())
    # Your code must call int_to_reverse_binary() to get 
    # the binary string of an integer in a reverse order.
    # Then call string_reverse() to reverse the string
    # returned from int_to_reverse_binary().
    print(int_to_reverse_binary(input_num))
