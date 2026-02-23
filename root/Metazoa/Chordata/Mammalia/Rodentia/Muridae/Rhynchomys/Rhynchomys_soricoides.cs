namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rhynchomys;

/// <summary>
/// Species: Rhynchomys soricoides
/// NCBI TaxId: 1217597
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhynchomys_soricoides : Rhynchomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhynchomys soricoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhynchomys_soricoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1217597;
}
