namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Leopardus;

/// <summary>
/// Species: Leopardus wiedii
/// NCBI TaxId: 61382
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leopardus_wiedii : Leopardus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leopardus wiedii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leopardus_wiedii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61382;
}
