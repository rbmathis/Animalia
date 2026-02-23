namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Heteromys;

/// <summary>
/// Species: Heteromys sp. VA-2008
/// NCBI TaxId: 513396
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heteromys_sp_VA_2008 : Heteromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heteromys sp. VA-2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heteromys_sp_VA_2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 513396;
}
