namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana;

/// <summary>
/// Species: Rana sauteri
/// NCBI TaxId: 325554
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rana_sauteri : Rana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rana sauteri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rana_sauteri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 325554;
}
