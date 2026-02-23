namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Leptobatrachus;

/// <summary>
/// Species: Leptobatrachus luteus
/// NCBI TaxId: 3681136
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptobatrachus_luteus : Leptobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptobatrachus luteus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptobatrachus_luteus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3681136;
}
