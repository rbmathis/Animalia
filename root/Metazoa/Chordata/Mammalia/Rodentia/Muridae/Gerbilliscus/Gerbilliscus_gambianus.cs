namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbilliscus;

/// <summary>
/// Species: Gerbilliscus gambianus
/// NCBI TaxId: 41264
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gerbilliscus_gambianus : Gerbilliscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gerbilliscus gambianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gerbilliscus_gambianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 41264;
}
