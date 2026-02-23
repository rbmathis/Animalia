namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Rhyacotritonidae.Rhyacotriton;

/// <summary>
/// Species: Rhyacotriton variegatus
/// NCBI TaxId: 291264
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhyacotriton_variegatus : Rhyacotriton
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhyacotriton variegatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhyacotriton_variegatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 291264;
}
