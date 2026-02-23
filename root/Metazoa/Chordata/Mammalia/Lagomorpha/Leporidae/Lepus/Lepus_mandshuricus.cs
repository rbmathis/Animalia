namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

/// <summary>
/// Species: Lepus mandshuricus
/// NCBI TaxId: 112021
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepus_mandshuricus : Lepus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepus mandshuricus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepus_mandshuricus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 112021;
}
