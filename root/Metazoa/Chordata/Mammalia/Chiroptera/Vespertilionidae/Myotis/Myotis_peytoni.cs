namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis peytoni
/// NCBI TaxId: 2291616
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_peytoni : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis peytoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_peytoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2291616;
}
