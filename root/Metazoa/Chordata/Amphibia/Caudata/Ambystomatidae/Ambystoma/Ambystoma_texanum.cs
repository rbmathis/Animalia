namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Ambystomatidae.Ambystoma;

/// <summary>
/// Species: Ambystoma texanum
/// NCBI TaxId: 8304
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ambystoma_texanum : Ambystoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ambystoma texanum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ambystoma_texanum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8304;
}
