namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Terrapene;

/// <summary>
/// Species: Terrapene mexicana
/// NCBI TaxId: 1415175
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Terrapene_mexicana : Terrapene
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Terrapene mexicana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Terrapene_mexicana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1415175;
}
