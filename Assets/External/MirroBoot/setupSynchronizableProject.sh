#!/bin/sh

PROJECT_DIR=$(cd ./; pwd)
PROJECT_NAME=`echo ${PROJECT_DIR} | awk -F "/" '{ print $(NF - 0) }'`
PROJECT_PATH="Synchronizable${PROJECT_NAME}"

mkdir ../${PROJECT_PATH}
rm -r ../${PROJECT_PATH}/*
EXPORT_DIR=$(cd ../${PROJECT_PATH}; pwd)

# clean and create symbolic link
folders=("Assets" "Packages" "ProjectSettings" "Library")

for FOLDER in ${folders[@]}
do
	echo "[ folders ] : "${FOLDER}
	mkdir -p ${EXPORT_DIR}/${FOLDER}/
	rm -r ${EXPORT_DIR}/${FOLDER}/*
	ln -s ${PROJECT_DIR}/${FOLDER}/* ${EXPORT_DIR}/${FOLDER}/
done
