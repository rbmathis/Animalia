namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Rheomys;

/// <summary>
/// Species: Rheomys raptor
/// NCBI TaxId: 218836
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rheomys_raptor : Rheomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rheomys raptor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rheomys_raptor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 218836;
}
