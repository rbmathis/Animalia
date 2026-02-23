namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Serengetimys;

/// <summary>
/// Species: Serengetimys pernanus
/// NCBI TaxId: 2912600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Serengetimys_pernanus : Serengetimys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Serengetimys pernanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Serengetimys_pernanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2912600;
}
