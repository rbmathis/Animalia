namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Leopardus;

/// <summary>
/// Species: Leopardus tigrinus
/// NCBI TaxId: 46842
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leopardus_tigrinus : Leopardus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leopardus tigrinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leopardus_tigrinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 46842;
}
