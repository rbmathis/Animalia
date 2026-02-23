namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Pipa;

/// <summary>
/// Species: Pipa snethlageae
/// NCBI TaxId: 2922209
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pipa_snethlageae : Pipa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pipa snethlageae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pipa_snethlageae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2922209;
}
