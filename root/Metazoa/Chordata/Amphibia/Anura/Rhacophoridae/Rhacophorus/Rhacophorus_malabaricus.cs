namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Rhacophorus;

/// <summary>
/// Species: Rhacophorus malabaricus
/// NCBI TaxId: 129031
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhacophorus_malabaricus : Rhacophorus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhacophorus malabaricus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhacophorus_malabaricus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 129031;
}
