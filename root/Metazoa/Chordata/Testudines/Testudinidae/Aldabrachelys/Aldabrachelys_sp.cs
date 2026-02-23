namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Aldabrachelys;

/// <summary>
/// Species: Aldabrachelys sp.
/// NCBI TaxId: 2804318
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aldabrachelys_sp : Aldabrachelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aldabrachelys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aldabrachelys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2804318;
}
