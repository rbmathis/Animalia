namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis parilis
/// NCBI TaxId: 1926525
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_parilis : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis parilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_parilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1926525;
}
