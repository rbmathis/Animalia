namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Leopardus;

/// <summary>
/// Species: Leopardus guigna
/// NCBI TaxId: 61386
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leopardus_guigna : Leopardus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leopardus guigna";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leopardus_guigna";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61386;
}
