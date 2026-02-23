namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Trachemys;

/// <summary>
/// Species: Trachemys ornata
/// NCBI TaxId: 904224
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachemys_ornata : Trachemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachemys ornata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachemys_ornata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904224;
}
