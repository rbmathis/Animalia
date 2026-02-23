namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis macropus
/// NCBI TaxId: 138979
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_macropus : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis macropus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_macropus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 138979;
}
