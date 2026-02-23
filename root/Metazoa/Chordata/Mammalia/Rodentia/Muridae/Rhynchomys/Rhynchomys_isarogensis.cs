namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rhynchomys;

/// <summary>
/// Species: Rhynchomys isarogensis
/// NCBI TaxId: 238000
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhynchomys_isarogensis : Rhynchomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhynchomys isarogensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhynchomys_isarogensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 238000;
}
