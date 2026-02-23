namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Terrapene;

/// <summary>
/// Species: Terrapene yucatana
/// NCBI TaxId: 3148702
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Terrapene_yucatana : Terrapene
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Terrapene yucatana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Terrapene_yucatana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3148702;
}
