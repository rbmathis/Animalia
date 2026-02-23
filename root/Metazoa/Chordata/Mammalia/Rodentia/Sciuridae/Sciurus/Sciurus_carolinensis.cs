namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurus;

/// <summary>
/// Species: Sciurus carolinensis
/// NCBI TaxId: 30640
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciurus_carolinensis : Sciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciurus carolinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciurus_carolinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30640;
}
