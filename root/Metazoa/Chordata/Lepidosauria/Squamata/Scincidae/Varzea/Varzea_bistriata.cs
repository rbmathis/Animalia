namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Varzea;

/// <summary>
/// Species: Varzea bistriata
/// NCBI TaxId: 111170
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varzea_bistriata : Varzea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varzea bistriata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varzea_bistriata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111170;
}
