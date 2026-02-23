namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis huariorum
/// NCBI TaxId: 2974270
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_huariorum : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis huariorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_huariorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2974270;
}
