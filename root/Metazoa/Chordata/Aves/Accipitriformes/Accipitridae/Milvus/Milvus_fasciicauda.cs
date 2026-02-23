namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Milvus;

/// <summary>
/// Species: Milvus fasciicauda
/// NCBI TaxId: 329125
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Milvus_fasciicauda : Milvus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Milvus fasciicauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Milvus_fasciicauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 329125;
}
