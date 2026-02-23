namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Oryx;

/// <summary>
/// Species: Oryx leucoryx
/// NCBI TaxId: 39411
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oryx_leucoryx : Oryx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oryx leucoryx";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oryx_leucoryx";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39411;
}
