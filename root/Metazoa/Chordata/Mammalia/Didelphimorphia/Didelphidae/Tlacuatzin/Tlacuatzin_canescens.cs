namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Tlacuatzin;

/// <summary>
/// Species: Tlacuatzin canescens
/// NCBI TaxId: 225728
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tlacuatzin_canescens : Tlacuatzin
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tlacuatzin canescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tlacuatzin_canescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 225728;
}
