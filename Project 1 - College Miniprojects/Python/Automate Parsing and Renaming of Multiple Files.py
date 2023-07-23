import os

os.chdir('E:\python_rename')
print(os.getcwd())
for f in os.listdir():
	f_name,f_ext = os.path.splitext(f)
	f_title, f_num = f_name.split('_ ')
	f_num = f_num.strip()[3:].zfill(3)
	new_name = '{}{}'.format(f_num,f_ext)
	os.rename(f,new_name)	