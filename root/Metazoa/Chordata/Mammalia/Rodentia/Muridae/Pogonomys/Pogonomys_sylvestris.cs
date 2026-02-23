namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pogonomys;

/// <summary>
/// Species: Pogonomys sylvestris
/// NCBI TaxId: 685446
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pogonomys_sylvestris : Pogonomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pogonomys sylvestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pogonomys_sylvestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 685446;
}
