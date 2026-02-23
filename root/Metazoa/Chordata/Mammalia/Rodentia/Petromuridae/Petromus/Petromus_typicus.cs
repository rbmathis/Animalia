namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Petromuridae.Petromus;

/// <summary>
/// Species: Petromus typicus
/// NCBI TaxId: 10183
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petromus_typicus : Petromus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petromus typicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petromus_typicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10183;
}
