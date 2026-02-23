namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Trogon;

/// <summary>
/// Species: Trogon clathratus
/// NCBI TaxId: 520021
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trogon_clathratus : Trogon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trogon clathratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trogon_clathratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 520021;
}
