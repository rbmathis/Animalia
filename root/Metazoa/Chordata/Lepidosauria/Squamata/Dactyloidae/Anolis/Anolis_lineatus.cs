namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis lineatus
/// NCBI TaxId: 75260
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_lineatus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis lineatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_lineatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75260;
}
