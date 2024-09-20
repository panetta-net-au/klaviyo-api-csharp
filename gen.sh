#!/bin/bash

kiota generate --openapi https://raw.githubusercontent.com/klaviyo/openapi/main/openapi/stable.json --namespace-name Klaviyo -l CSharp -o KlaviyoApi
