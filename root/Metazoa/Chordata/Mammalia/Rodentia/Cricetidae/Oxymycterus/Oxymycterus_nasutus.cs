namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oxymycterus;

/// <summary>
/// Species: Oxymycterus nasutus
/// NCBI TaxId: 134911
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oxymycterus_nasutus : Oxymycterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oxymycterus nasutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oxymycterus_nasutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 134911;
}
