num_rows = int(input())
num_columns = int(input())

col_val = 1
row_val = 'A'

while row_val <= 'C':
    while col_val <= num_columns:
        print(f'{row_val}{col_val}', end='')
        col_val += 1
    print()
    
