namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Desmodilliscus;

/// <summary>
/// Species: Desmodilliscus braueri
/// NCBI TaxId: 298892
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Desmodilliscus_braueri : Desmodilliscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Desmodilliscus braueri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Desmodilliscus_braueri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 298892;
}
