namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Akodon;

/// <summary>
/// Species: Akodon viridescens
/// NCBI TaxId: 747232
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Akodon_viridescens : Akodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Akodon viridescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Akodon_viridescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 747232;
}
