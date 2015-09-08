using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace AzureWebApp
{
    public static class MeetuphhAppServiceExtensions
    {
        public static Meetuphh CreateMeetuphh(this IAppServiceClient client)
        {
            return new Meetuphh(client.CreateHandler());
        }

        public static Meetuphh CreateMeetuphh(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new Meetuphh(client.CreateHandler(handlers));
        }

        public static Meetuphh CreateMeetuphh(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new Meetuphh(uri, client.CreateHandler(handlers));
        }

        public static Meetuphh CreateMeetuphh(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new Meetuphh(rootHandler, client.CreateHandler(handlers));
        }
    }
}
