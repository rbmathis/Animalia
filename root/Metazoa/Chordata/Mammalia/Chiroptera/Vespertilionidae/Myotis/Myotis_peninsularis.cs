namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis peninsularis
/// NCBI TaxId: 2890400
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_peninsularis : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis peninsularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_peninsularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2890400;
}
