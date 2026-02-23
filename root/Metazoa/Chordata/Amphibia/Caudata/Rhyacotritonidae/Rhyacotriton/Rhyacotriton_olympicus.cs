namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Rhyacotritonidae.Rhyacotriton;

/// <summary>
/// Species: Rhyacotriton olympicus
/// NCBI TaxId: 43569
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhyacotriton_olympicus : Rhyacotriton
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhyacotriton olympicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhyacotriton_olympicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43569;
}
