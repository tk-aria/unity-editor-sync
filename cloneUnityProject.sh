#!/bin/sh

# [ 汎用 ] ScriptPathの取得. 
SCRIPT_DIR=$(cd $(dirname $0); pwd)
PROJECT_DIR=$(cd ./; pwd)

PROJECT_NAME="UnityProj_SymbolicLink"

mkdir ../${PROJECT_NAME}
rm -r ../${PROJECT_NAME}/*
CLONE_DIR=$(cd ../${PROJECT_NAME}; pwd)

# clean and create symbolic link
folders=("Assets" "Packages" "ProjectSettings")

for FOLDER in ${folders[@]}
do
    echo "[ folders ] : "${FOLDER}
    mkdir -p ${CLONE_DIR}/${FOLDER}/
    rm -r ${CLONE_DIR}/${FOLDER}/*
    ln -s ${PROJECT_DIR}/${FOLDER}/* ${CLONE_DIR}/${FOLDER}/
done
