namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Maxomys;

/// <summary>
/// Species: Maxomys musschenbroekii
/// NCBI TaxId: 907926
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Maxomys_musschenbroekii : Maxomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Maxomys musschenbroekii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Maxomys_musschenbroekii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 907926;
}
