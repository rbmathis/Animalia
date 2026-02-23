namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Notiomys;

/// <summary>
/// Species: Notiomys edwardsii
/// NCBI TaxId: 29119
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Notiomys_edwardsii : Notiomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Notiomys edwardsii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Notiomys_edwardsii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29119;
}
