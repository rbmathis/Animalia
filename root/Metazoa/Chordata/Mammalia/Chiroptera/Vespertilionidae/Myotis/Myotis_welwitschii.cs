namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis welwitschii
/// NCBI TaxId: 160974
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_welwitschii : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis welwitschii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_welwitschii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 160974;
}
