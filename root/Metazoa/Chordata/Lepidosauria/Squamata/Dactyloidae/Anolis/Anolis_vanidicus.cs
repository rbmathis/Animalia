namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis vanidicus
/// NCBI TaxId: 75273
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_vanidicus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis vanidicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_vanidicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75273;
}
