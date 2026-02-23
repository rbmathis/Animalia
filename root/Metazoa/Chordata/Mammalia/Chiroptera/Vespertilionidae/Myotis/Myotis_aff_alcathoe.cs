namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis aff. alcathoe
/// NCBI TaxId: 1436298
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_aff_alcathoe : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis aff. alcathoe";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_aff_alcathoe";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1436298;
}
