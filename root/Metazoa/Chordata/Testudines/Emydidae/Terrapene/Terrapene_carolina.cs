namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Terrapene;

/// <summary>
/// Species: Terrapene carolina
/// NCBI TaxId: 158814
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Terrapene_carolina : Terrapene
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Terrapene carolina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Terrapene_carolina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 158814;
}
