namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Pipa;

/// <summary>
/// Species: Pipa aspera
/// NCBI TaxId: 2922207
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pipa_aspera : Pipa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pipa aspera";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pipa_aspera";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2922207;
}
