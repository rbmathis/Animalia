namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Terrapene;

/// <summary>
/// Species: Terrapene ornata
/// NCBI TaxId: 85611
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Terrapene_ornata : Terrapene
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Terrapene ornata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Terrapene_ornata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 85611;
}
