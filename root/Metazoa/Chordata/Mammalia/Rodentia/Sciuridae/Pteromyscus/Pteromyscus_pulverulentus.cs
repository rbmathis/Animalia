namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Pteromyscus;

/// <summary>
/// Species: Pteromyscus pulverulentus
/// NCBI TaxId: 226817
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pteromyscus_pulverulentus : Pteromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pteromyscus pulverulentus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pteromyscus_pulverulentus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 226817;
}
