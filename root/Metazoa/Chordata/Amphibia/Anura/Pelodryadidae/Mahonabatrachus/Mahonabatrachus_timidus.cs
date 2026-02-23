namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Mahonabatrachus;

/// <summary>
/// Species: Mahonabatrachus timidus
/// NCBI TaxId: 3681075
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mahonabatrachus_timidus : Mahonabatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mahonabatrachus timidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mahonabatrachus_timidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3681075;
}
