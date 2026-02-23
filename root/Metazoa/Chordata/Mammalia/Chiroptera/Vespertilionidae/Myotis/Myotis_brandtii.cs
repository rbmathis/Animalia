namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis brandtii
/// NCBI TaxId: 109478
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_brandtii : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis brandtii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_brandtii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109478;
}
