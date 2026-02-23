namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis porcatus x Anolis allisoni
/// NCBI TaxId: 301360
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_porcatus_x_Anolis_allisoni : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis porcatus x Anolis allisoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_porcatus_x_Anolis_allisoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 301360;
}
