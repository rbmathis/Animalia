namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phodopus;

/// <summary>
/// Species: Phodopus roborovskii
/// NCBI TaxId: 109678
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phodopus_roborovskii : Phodopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phodopus roborovskii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phodopus_roborovskii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109678;
}
