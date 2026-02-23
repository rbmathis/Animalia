namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Pipa;

/// <summary>
/// Species: Pipa pipa
/// NCBI TaxId: 251750
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pipa_pipa : Pipa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pipa pipa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pipa_pipa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 251750;
}
