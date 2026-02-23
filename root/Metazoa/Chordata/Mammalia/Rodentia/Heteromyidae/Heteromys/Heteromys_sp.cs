namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Heteromys;

/// <summary>
/// Species: Heteromys sp.
/// NCBI TaxId: 3137349
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heteromys_sp : Heteromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heteromys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heteromys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3137349;
}
