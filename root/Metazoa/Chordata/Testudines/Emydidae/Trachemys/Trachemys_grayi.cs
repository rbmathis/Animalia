namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Trachemys;

/// <summary>
/// Species: Trachemys grayi
/// NCBI TaxId: 365639
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachemys_grayi : Trachemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachemys grayi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachemys_grayi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 365639;
}
