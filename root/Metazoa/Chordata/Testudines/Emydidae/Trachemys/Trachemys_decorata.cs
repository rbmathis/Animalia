namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Trachemys;

/// <summary>
/// Species: Trachemys decorata
/// NCBI TaxId: 365623
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachemys_decorata : Trachemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachemys decorata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachemys_decorata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 365623;
}
