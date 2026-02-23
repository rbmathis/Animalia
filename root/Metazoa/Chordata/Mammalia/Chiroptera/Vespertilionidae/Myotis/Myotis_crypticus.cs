namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis crypticus
/// NCBI TaxId: 2528591
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_crypticus : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis crypticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_crypticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2528591;
}
