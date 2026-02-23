namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Mahonabatrachus;

/// <summary>
/// Species: Mahonabatrachus aurifer
/// NCBI TaxId: 3681031
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mahonabatrachus_aurifer : Mahonabatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mahonabatrachus aurifer";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mahonabatrachus_aurifer";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3681031;
}
