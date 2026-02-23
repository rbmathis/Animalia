namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae.Leiosaurus;

/// <summary>
/// Species: Leiosaurus catamarcensis
/// NCBI TaxId: 161146
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leiosaurus_catamarcensis : Leiosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leiosaurus catamarcensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leiosaurus_catamarcensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 161146;
}
