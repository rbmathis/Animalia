namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Scapteromys;

/// <summary>
/// Species: Scapteromys tumidus
/// NCBI TaxId: 89126
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scapteromys_tumidus : Scapteromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scapteromys tumidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scapteromys_tumidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89126;
}
