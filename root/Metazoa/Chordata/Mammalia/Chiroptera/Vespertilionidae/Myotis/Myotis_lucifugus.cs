namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis lucifugus
/// NCBI TaxId: 59463
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_lucifugus : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis lucifugus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_lucifugus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59463;
}
