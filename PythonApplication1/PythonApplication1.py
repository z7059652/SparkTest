import codecs

fileReader = codecs.open('A-large.in','r','utf-8')
allLines = fileReader.readlines()

num_testcases = int(allLines[0][:-1])

leader_names = []
line_no = 1

for i in range(num_testcases):
	names_num = int(allLines[line_no][:-1])
	names_alphabet_map = {}
	MaxAlpLen = 0
	line_no += 1
	for j in range(names_num):
		alphabet_map = {}
		name = allLines[line_no][:-1]
		line_no += 1
		for alphabet in name:
			if alphabet != ' ':
				alphabet_map[alphabet] = 1
		names_alphabet_map[name] = len(alphabet_map)
		MaxAlpLen = max(MaxAlpLen,len(alphabet_map))


	top_names_list = []
	for name in names_alphabet_map:
		if names_alphabet_map[name] == MaxAlpLen:
			top_names_list.append(name)
	top_names_list.sort()

	leader_names.append(top_names_list[0])

fileReader = codecs.open('A-small.out','w','utf-8')
write_results = []
for i in range(len(leader_names)):
	write_results.append('Case #'+str(i+1)+": "+leader_names[i]+'\n')
fileReader.writelines(write_results)
fileReader.close()




