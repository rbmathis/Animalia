namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Ambystomatidae.Ambystoma;

/// <summary>
/// Species: Ambystoma mexicanum
/// NCBI TaxId: 8296
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ambystoma_mexicanum : Ambystoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ambystoma mexicanum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ambystoma_mexicanum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8296;
}
