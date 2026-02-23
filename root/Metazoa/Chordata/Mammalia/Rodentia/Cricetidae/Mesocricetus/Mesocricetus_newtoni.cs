namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Mesocricetus;

/// <summary>
/// Species: Mesocricetus newtoni
/// NCBI TaxId: 329624
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesocricetus_newtoni : Mesocricetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesocricetus newtoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesocricetus_newtoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 329624;
}
