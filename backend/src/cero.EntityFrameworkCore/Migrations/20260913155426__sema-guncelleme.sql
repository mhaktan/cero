-- Migration 20260913155426 — sema-guncelleme
-- Provider: postgresql
ALTER TABLE "PurchaseRequests" ALTER COLUMN "Status" TYPE integer;

ALTER TABLE "PurchaseRequests" ALTER COLUMN "Status" SET NOT NULL;
