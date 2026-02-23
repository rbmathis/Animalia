namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Sandyrana;

/// <summary>
/// Species: Sandyrana sanguinolenta
/// NCBI TaxId: 3681167
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sandyrana_sanguinolenta : Sandyrana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sandyrana sanguinolenta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sandyrana_sanguinolenta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3681167;
}
