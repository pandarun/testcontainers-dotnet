#!/usr/bin/env bash

set -e

API_KEY=$1
SOURCE=$2
CONFIGURATION="Release"

function remote_publish() {
    dotnet pack $1 -c ${CONFIGURATION}
    dotnet nuget push $2/bin/${CONFIGURATION}/$3.*.nupkg -s ${SOURCE} -k ${API_KEY}
}

PROJECT_DIR="src/Container.Abstractions"
CSPROJ="${PROJECT_DIR}/Container.Abstractions.csproj"
ASSEMBLY_NAME="TestContainers.Container.Abstractions"

remote_publish ${CSPROJ} ${ASSEMBLY_NAME} ${PROJECT_DIR}

PROJECT_DIR="src/Container.Database"
CSPROJ="${PROJECT_DIR}/Container.Database.csproj"
ASSEMBLY_NAME="TestContainers.Container.Database"

remote_publish ${CSPROJ} ${ASSEMBLY_NAME} ${PROJECT_DIR}

PROJECT_DIR="src/Container.Database.AdoNet"
CSPROJ="${PROJECT_DIR}/Container.Database.AdoNet.csproj"
ASSEMBLY_NAME="TestContainers.Container.Database.AdoNet"

remote_publish ${CSPROJ} ${ASSEMBLY_NAME} ${PROJECT_DIR}

PROJECT_DIR="src/Container.Database.PostgreSql"
CSPROJ="${PROJECT_DIR}/Container.Database.PostgreSql.csproj"
ASSEMBLY_NAME="TestContainers.Container.Database.PostgreSql"

remote_publish ${CSPROJ} ${ASSEMBLY_NAME} ${PROJECT_DIR}