import type { Metadata } from "next";
import "@/app/style/globals.css";
import { AppRouterCacheProvider } from '@mui/material-nextjs/v15-appRouter'
import { Toaster } from "sonner";


export const metadata: Metadata = {
  title: "Polls App",
  description: "Vote and make Polls",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body>
        <AppRouterCacheProvider>{children}</AppRouterCacheProvider>
        <Toaster />
      </body>
    </html>
  );
}
