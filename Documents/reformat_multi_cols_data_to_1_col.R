
#get link the input file
link_input_file = paste0(getwd(), "/SAX_update/SAX_update/bin/Debug/Data/ERP_data.dat")

#get link and name the output file
link_output = paste0(getwd(), "/SAX_update/SAX_update/bin/Debug/Data/ERP_1_col.csv")

#read file to R
input_data = read.csv(link_input_file, sep="", header = F)

#check input_data
#View(input_data)

#convert the input_data to just 1 col
data_one_col =as.vector(t(input_data))

#check
#View(data.frame(data_one_col))

#write to file
write.csv(data_one_col, link_output, row.names=F)

