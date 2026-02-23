namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae.Brachycephalus;

/// <summary>
/// Species: Brachycephalus sp. 'curupira'
/// NCBI TaxId: 2017222
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brachycephalus_sp_curupira : Brachycephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brachycephalus sp. 'curupira'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brachycephalus_sp_curupira";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2017222;
}
