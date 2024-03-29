// https://msdn.microsoft.com/en-us/library/windows/desktop/aa379797(v=vs.85).aspx
//

#include "stdafx.h"
#include <winscard.h>
#include <iostream>
using namespace std;

int main()
{
	SCARDCONTEXT    hCardContext;
	SCARDHANDLE     hCardHandle;
	LONG            lReturn;
	DWORD           dwAPch;
	DWORD           dwAP;
	// Establish the context.
	lReturn = SCardEstablishContext(SCARD_SCOPE_USER,
		NULL,
		NULL,
		&hCardContext);
	if (SCARD_S_SUCCESS != lReturn) {
		printf("Failed SCardEstablishContext\n");
	}
	else
	{
		lReturn = SCardConnect(hCardContext,
			L"Secure Flash Card 0",
			SCARD_SHARE_SHARED,
			SCARD_PROTOCOL_T0 | SCARD_PROTOCOL_T1,
			&hCardHandle,
			&dwAPch);
		if (SCARD_S_SUCCESS != lReturn) {
			printf("Failed SCardConnect\n");
			printf("%lu", lReturn);
			printf("\n");
			//exit(1);  // Or other appropriate action.
		}

		lReturn = SCardReconnect(hCardHandle,
			SCARD_SHARE_SHARED,
			SCARD_PROTOCOL_T0 | SCARD_PROTOCOL_T1,
			SCARD_LEAVE_CARD,
			&dwAP);
		if (SCARD_S_SUCCESS != lReturn) {
			printf("Failed SCardReconnect\n");
			printf("%lu", lReturn);
			printf("\n");
		}

		lReturn = SCardDisconnect(hCardContext,
			SCARD_LEAVE_CARD);
		if (SCARD_S_SUCCESS != lReturn)
		{
			printf("Failed SCardDisconnect\n");
			printf("%lu", lReturn);
			printf("\n");
			//exit(1);  // Or other appropriate action.
		}
	}

	lReturn = SCardReleaseContext(hCardContext);
	if (SCARD_S_SUCCESS != lReturn) {
		printf("Failed SCardReleaseContext\n");
		printf("%lu", lReturn);
		printf("\n");
	}

	cin.get();
	return 0;
}

