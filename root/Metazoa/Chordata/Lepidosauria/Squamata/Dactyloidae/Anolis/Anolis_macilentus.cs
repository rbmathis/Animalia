namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis macilentus
/// NCBI TaxId: 235314
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_macilentus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis macilentus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_macilentus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 235314;
}
