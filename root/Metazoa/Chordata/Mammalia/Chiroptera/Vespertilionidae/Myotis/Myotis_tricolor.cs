namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis tricolor
/// NCBI TaxId: 233765
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_tricolor : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis tricolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_tricolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 233765;
}
