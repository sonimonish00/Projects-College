"""
The text file contains city names and states it belongs to. Each line contains the name of the city, name of the state. (Eg: Ahmedabad, Gujarat).  Read in the file and create an alphabetically ordered list (both city wise or state wise). Print the total number of cities belongs to particular state. For Example, if user provides an input “Gujarat” state, then it should print all the cities belongs to Gujarat State along with number of cities. Store the sorted information in another file (state wise)
"""

"""
Amreli,Gujarat
Adilabad,Andhra Pradesh  
East Delhi,Delhi                  
Anantapur,Andhra Pradesh
Anand,Gujarat
Banaskantha,Gujarat
Arwal,Bihar
Aurangabad,Bihar
Chittoor,Andhra Pradesh
Banka,Bihar
Kakinada,Andhra Pradesh
Karimnagar,Andhra Pradesh
Central Delhi,Delhi
Khammam,Andhra Pradesh
Araria,Bihar
Bastar,Chhattisgarh
Dahod,Gujarat
Bijapur,Chhattisgarh
Bhavnagar,Gujarat
Bilaspur,Chhattisgarh
Bharuch,Gujarat
Dantewada,Chhattisgarh
New Delhi,Delhi
Guntur,Andhra Pradesh
Hyderabad,Andhra Pradesh
North Delhi,Delhi
Ahmedabad,Gujarat
"""
def check(search_state):
	if search_state in open('E:\output.txt').read():
		return True
	else:
		return False

def search_state(search_state):
	search_citylist = []
	if check(search_state) is True:
		with open('E:\output.txt','r+') as f:
			for line in f:
				if search_state in line:
					currcity = line.split(',')[1]
					currcity = currcity.strip('\n')
					search_citylist.append(currcity)
			search_citylist = sorted(set(search_citylist))

		length = len(search_citylist)
		print("The Total No. of Cities in {0} are: ".format(search_state)+str(length))
		print("The Cities in {0} State are: ".format(search_state))
		print(search_citylist)
	else:
		print("Sorry State is not Found")

def main():
	"""
		There are 3 Main Things 1.Sort State and City Wise 2.Store them into output.txt 3.Search Facility
	"""
	statelist = []
	citylist = []
	with open('E:\input.txt','r+') as f,open('E:\output.txt','w+') as f1:
		for line in f:
			#Getting only State Name - StateWise Sorted
			currentstate = line.split(',')[1]
			currentstate = currentstate.strip('\n')
			statelist.append(currentstate)
		statelist = sorted(set(statelist))
		#Main Point to Reset the Pointer to Read multiple times lines of the same file
		f.seek(0)
		#City Wise Sorted in States and Output to A File.
		for state in statelist:
			for line in f:
				if state in line:
					currentcity = line.split(',')[0]
					currentcity = currentcity.strip('\n')
					citylist.append(currentcity)
			citylist = sorted(set(citylist))

			for city in citylist:
				f1.write("{0},{1}\n".format(state,city))

			#Clearing List for Reuse
			citylist[:] = []
			f.seek(0)

	state = input("Enter The State Name (Case Sensitive as of Now) : ")
	search_state(state)
	
if __name__ == '__main__':
    main()
