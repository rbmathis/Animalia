namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurus;

/// <summary>
/// Species: Sciurus granatensis
/// NCBI TaxId: 226870
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciurus_granatensis : Sciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciurus granatensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciurus_granatensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 226870;
}
