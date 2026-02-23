namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurus;

/// <summary>
/// Species: Sciurus gilvigularis
/// NCBI TaxId: 1473560
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciurus_gilvigularis : Sciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciurus gilvigularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciurus_gilvigularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1473560;
}
