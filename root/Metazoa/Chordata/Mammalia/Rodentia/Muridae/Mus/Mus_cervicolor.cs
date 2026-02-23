namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus cervicolor
/// NCBI TaxId: 10097
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_cervicolor : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus cervicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_cervicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10097;
}
