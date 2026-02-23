namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Phyllomys;

/// <summary>
/// Species: Phyllomys unicolor
/// NCBI TaxId: 466165
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllomys_unicolor : Phyllomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllomys unicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllomys_unicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 466165;
}
