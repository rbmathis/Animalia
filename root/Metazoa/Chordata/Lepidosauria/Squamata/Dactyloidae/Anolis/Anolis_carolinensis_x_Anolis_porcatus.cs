namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis carolinensis x Anolis porcatus
/// NCBI TaxId: 1442387
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_carolinensis_x_Anolis_porcatus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis carolinensis x Anolis porcatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_carolinensis_x_Anolis_porcatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1442387;
}
