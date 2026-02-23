namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis fimbriatus
/// NCBI TaxId: 452653
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_fimbriatus : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis fimbriatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_fimbriatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 452653;
}
