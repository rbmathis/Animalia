namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Mahonabatrachus;

/// <summary>
/// Species: Mahonabatrachus longirostris
/// NCBI TaxId: 3681055
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mahonabatrachus_longirostris : Mahonabatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mahonabatrachus longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mahonabatrachus_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3681055;
}
