FROM golang:1.10-nanoserver as workspace
WORKDIR /go/src/github.com/testcontainers/moby-ryuk

WORKDIR /make
COPY make-3.81-bin.zip ./
RUN Expand-Archive -Path .\make-3.81-bin.zip -DestinationPath . 
#RUN new-item alias:make -value "$pwd\bin\make.exe"

WORKDIR /go/src/github.com/testcontainers/moby-ryuk
COPY glide.lock glide.yaml Makefile ./
RUN /make/bin/make.exe bootstrap
COPY . .
RUN /make/bin/make.exe build

FROM mcr.microsoft.com/windows/nanoserver:sac2016
RUN apk --no-cache add ca-certificates
COPY --from=workspace /go/src/github.com/testcontainers/moby-ryuk/bin/moby-ryuk /app
CMD ["/app"]
