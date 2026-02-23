namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis lucius
/// NCBI TaxId: 38898
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_lucius : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis lucius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_lucius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38898;
}
