namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis peucephilus
/// NCBI TaxId: 1441880
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_peucephilus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis peucephilus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_peucephilus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1441880;
}
