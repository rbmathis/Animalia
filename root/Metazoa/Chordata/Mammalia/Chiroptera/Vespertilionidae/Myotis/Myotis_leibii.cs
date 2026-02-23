namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis leibii
/// NCBI TaxId: 27668
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_leibii : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis leibii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_leibii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27668;
}
