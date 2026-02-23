namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurus;

/// <summary>
/// Species: Sciurus aberti
/// NCBI TaxId: 10007
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciurus_aberti : Sciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciurus aberti";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciurus_aberti";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10007;
}
