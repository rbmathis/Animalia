namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Trachycephalus;

/// <summary>
/// Species: Trachycephalus hadroceps
/// NCBI TaxId: 318374
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachycephalus_hadroceps : Trachycephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachycephalus hadroceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachycephalus_hadroceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318374;
}
