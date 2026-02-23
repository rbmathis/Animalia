namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis caucensis
/// NCBI TaxId: 3098845
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_caucensis : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis caucensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_caucensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3098845;
}
