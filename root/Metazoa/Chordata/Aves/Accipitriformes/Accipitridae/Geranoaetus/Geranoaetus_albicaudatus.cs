namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Geranoaetus;

/// <summary>
/// Species: Geranoaetus albicaudatus
/// NCBI TaxId: 223485
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geranoaetus_albicaudatus : Geranoaetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geranoaetus albicaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geranoaetus_albicaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 223485;
}
