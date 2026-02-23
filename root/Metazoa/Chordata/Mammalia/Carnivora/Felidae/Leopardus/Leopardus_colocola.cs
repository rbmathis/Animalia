namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Leopardus;

/// <summary>
/// Species: Leopardus colocola
/// NCBI TaxId: 3055696
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leopardus_colocola : Leopardus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leopardus colocola";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leopardus_colocola";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3055696;
}
