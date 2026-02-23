namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurus;

/// <summary>
/// Species: Sciurus niger
/// NCBI TaxId: 34861
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciurus_niger : Sciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciurus niger";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciurus_niger";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34861;
}
