namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Trachemys;

/// <summary>
/// Species: Trachemys terrapen
/// NCBI TaxId: 365627
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachemys_terrapen : Trachemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachemys terrapen";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachemys_terrapen";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 365627;
}
