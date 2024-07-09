ARG VARIANT=8.0-bookworm-slim
FROM mcr.microsoft.com/dotnet/sdk:${VARIANT}
ARG DEBIAN_FRONTEND=noninteractive

RUN apt-get update && \
    apt-get install -qq -y curl mariadb-client bat exa ca-certificates gnupg sudo && \
    mkdir -p /etc/apt/keyrings && \
    curl -fsSL https://deb.nodesource.com/gpgkey/nodesource-repo.gpg.key | gpg --dearmor -o /etc/apt/keyrings/nodesource.gpg && \
    echo "deb [signed-by=/etc/apt/keyrings/nodesource.gpg] https://deb.nodesource.com/node_22.x nodistro main" > /etc/apt/sources.list.d/nodesource.list && \
    apt-get update && \
    apt-get install -qq -y nodejs && \
    npm i npm@latest -g && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

ARG USERNAME=vscode
ARG USER_UID=1000
ARG USER_GID=$USER_UID

RUN groupadd --gid $USER_GID $USERNAME \
    && useradd --uid $USER_UID --gid $USER_GID -m $USERNAME \
    && echo $USERNAME ALL=\(root\) NOPASSWD:ALL > /etc/sudoers.d/$USERNAME \
    && chmod 0440 /etc/sudoers.d/$USERNAME

USER $USERNAME
WORKDIR /home/$USERNAME
ENV PATH $PATH:/home/$USERNAME/.dotnet:/home/$USERNAME/.dotnet/tools
