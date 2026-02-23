namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis rubribarbus
/// NCBI TaxId: 323615
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_rubribarbus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis rubribarbus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_rubribarbus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 323615;
}
