namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oxymycterus;

/// <summary>
/// Species: Oxymycterus rufus
/// NCBI TaxId: 56230
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oxymycterus_rufus : Oxymycterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oxymycterus rufus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oxymycterus_rufus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56230;
}
