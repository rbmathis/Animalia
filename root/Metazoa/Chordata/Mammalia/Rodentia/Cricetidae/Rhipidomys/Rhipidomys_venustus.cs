namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Rhipidomys;

/// <summary>
/// Species: Rhipidomys venustus
/// NCBI TaxId: 2028305
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhipidomys_venustus : Rhipidomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhipidomys venustus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhipidomys_venustus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2028305;
}
