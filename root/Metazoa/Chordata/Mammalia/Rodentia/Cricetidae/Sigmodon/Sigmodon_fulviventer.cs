namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Sigmodon;

/// <summary>
/// Species: Sigmodon fulviventer
/// NCBI TaxId: 89246
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sigmodon_fulviventer : Sigmodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sigmodon fulviventer";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sigmodon_fulviventer";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89246;
}
