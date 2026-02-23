namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Muscardinus;

/// <summary>
/// Species: Muscardinus avellanarius
/// NCBI TaxId: 39082
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Muscardinus_avellanarius : Muscardinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Muscardinus avellanarius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Muscardinus_avellanarius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39082;
}
