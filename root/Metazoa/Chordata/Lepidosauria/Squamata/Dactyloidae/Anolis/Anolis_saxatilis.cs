namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis saxatilis
/// NCBI TaxId: 2653778
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_saxatilis : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis saxatilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_saxatilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2653778;
}
