namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis pilosatibialis
/// NCBI TaxId: 2940081
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_pilosatibialis : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis pilosatibialis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_pilosatibialis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2940081;
}
