namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus macedonicus
/// NCBI TaxId: 10100
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_macedonicus : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus macedonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_macedonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10100;
}
