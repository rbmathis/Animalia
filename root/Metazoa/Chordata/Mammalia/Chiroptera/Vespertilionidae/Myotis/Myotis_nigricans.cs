namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis nigricans
/// NCBI TaxId: 153286
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_nigricans : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis nigricans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_nigricans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 153286;
}
