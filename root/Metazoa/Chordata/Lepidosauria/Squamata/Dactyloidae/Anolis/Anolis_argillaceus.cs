namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis argillaceus
/// NCBI TaxId: 38883
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_argillaceus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis argillaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_argillaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38883;
}
