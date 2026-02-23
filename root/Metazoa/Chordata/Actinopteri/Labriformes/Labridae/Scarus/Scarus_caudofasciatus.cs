namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Scarus;

/// <summary>
/// Species: Scarus caudofasciatus
/// NCBI TaxId: 2913888
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scarus_caudofasciatus : Scarus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scarus caudofasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scarus_caudofasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2913888;
}
