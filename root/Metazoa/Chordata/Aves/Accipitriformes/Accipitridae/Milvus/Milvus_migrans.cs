namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Milvus;

/// <summary>
/// Species: Milvus migrans
/// NCBI TaxId: 52810
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Milvus_migrans : Milvus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Milvus migrans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Milvus_migrans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52810;
}
