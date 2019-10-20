import os
import folium
from folium import plugins
import numpy as np
import rasterio as rasterio
from rasterio.warp import calculate_default_transform, reproject, Resampling
from IPython.display import HTML, display
import csv
import xlrd
from array import array
import math

def find_nearest(array, value):
    array = np.asarray(array)
    idx = (np.abs(array - value)).argmin()
    return idx

def isInArea(latitudPoint,latitudCountry,longitudPoint,longitudCountry, radio):
	diferencia = latitudPoint-latitudCountry
	if diferencia >
	distance = math.sqrt(math.pow((latitudPoint-latitudCountry),2)+math.pow((longitudPoint-longitudCountry),2))
	if distance <= radio:
		return True
	else:
		return False


m = folium.Map(location=[40.0150, -105.2705])
line_count = 0

dictionaryCountriesNames = {}
arrayLongitud = []
arrayLatitud = []
numEarthquakes = {}

# Give the location of the file 
loc = ("finalPaises.xlsx")

# To open Workbook 
wb = xlrd.open_workbook(loc) 
sheet = wb.sheet_by_index(0) 
tam = sheet.nrows
 
i = 0
while i < tam:
	#latitud=((sheet.cell_value(i,3)/60)+sheet.cell_value(i,2))/60+sheet.cell_value(i,1)
	#longitud=((sheet.cell_value(i,6)/60)+sheet.cell_value(i,5))/60+sheet.cell_value(i,4)
	latitud=sheet.cell_value(i,1)
	longitud=sheet.cell_value(i,2)

	if i != 0:
		dictionaryCountriesNames[str(i)] = sheet.cell_value(i,0)
		numEarthquakes[sheet.cell_value(i,0)] = 0
		arrayLongitud.append(longitud)
		arrayLatitud.append(latitud)
		folium.Marker(
		location=[latitud,longitud], # coordinates for the marker (Earth Lab at CU Boulder)
		popup=sheet.cell_value(i,0), # pop-up label for the marker
		icon=folium.Icon()
		).add_to(m)
	i+=1


#Suponemos que 200km son 3 grados
radio = 5.0

line_count = 0

with open('database.csv') as csv_file:
	csv_reader = csv.reader(csv_file,delimiter=',')
	for row in csv_reader:
		if line_count != 0:
			encontrado = False

			while encontrado == False:

				valueFirst = float(row[3])-radio
				valueLast = float(row[3])+radio
				indexFirst = find_nearest(arrayLongitud,valueFirst) 
				indexLast = find_nearest(arrayLongitud,valueLast)

				for x in range(indexFirst,indexLast):
					if isInArea(float(row[3]),arrayLatitud[x],float(row[2]),arrayLongitud[x],radio) == True:
						encontrado = True
						numEarthquakes[dictionaryCountriesNames[str(x)]] += 1

				if encontrado == False and radio<15:
					radio += 1.0
				else:
					radio = 5.0
					encontrado = True
		line_count+=1
    

i = 0
while i < tam-1:
	latitud=arrayLatitud[i]
	longitud=arrayLongitud[i]

	dictionaryCountriesNames[str(i+1)] 
	#print("Pais: "+dictionaryCountriesNames[str(i+1)]+" Num: "+str(numEarthquakes[dictionaryCountriesNames[str(i+1)]]))
	titulo = "Pais: "+dictionaryCountriesNames[str(i+1)]+" Num: "+str(numEarthquakes[dictionaryCountriesNames[str(i+1)]])
	folium.Marker(
	location=[latitud,longitud],
	popup=titulo,
	icon=folium.Icon()
	).add_to(m)
	i+=1

m.save('map.html')