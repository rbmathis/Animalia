namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Emys;

/// <summary>
/// Species: Emys trinacris
/// NCBI TaxId: 334583
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Emys_trinacris : Emys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Emys trinacris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Emys_trinacris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 334583;
}
