namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Hyloxalus;

/// <summary>
/// Species: Hyloxalus sylvaticus
/// NCBI TaxId: 384892
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyloxalus_sylvaticus : Hyloxalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyloxalus sylvaticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyloxalus_sylvaticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 384892;
}
