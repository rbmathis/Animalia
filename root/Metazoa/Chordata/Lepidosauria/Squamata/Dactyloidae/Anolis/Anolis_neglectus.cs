namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis neglectus
/// NCBI TaxId: 2653710
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_neglectus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis neglectus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_neglectus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2653710;
}
