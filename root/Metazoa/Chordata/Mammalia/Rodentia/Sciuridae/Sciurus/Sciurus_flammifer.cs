namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurus;

/// <summary>
/// Species: Sciurus flammifer
/// NCBI TaxId: 1473544
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciurus_flammifer : Sciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciurus flammifer";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciurus_flammifer";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1473544;
}
