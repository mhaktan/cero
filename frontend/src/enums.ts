// ---------------------------------------------------------------------------
// Enum definitions — auto-generated from ER model
// Maps integer values to display labels for enum fields
// ---------------------------------------------------------------------------

// PurchaseRequest.status
export const PurchaseRequestStatusMap: Record<string, string> = {
  '0': 'Draft',
  '1': 'PendingManagerApproval',
  '2': 'PendingFinanceApproval',
  '3': 'PendingDirectorApproval',
  '4': 'Approved',
  '5': 'Ordered'
};
export const PurchaseRequestStatusOptions = [
  { label: 'Draft', value: '0' },
  { label: 'PendingManagerApproval', value: '1' },
  { label: 'PendingFinanceApproval', value: '2' },
  { label: 'PendingDirectorApproval', value: '3' },
  { label: 'Approved', value: '4' },
  { label: 'Ordered', value: '5' }
];
