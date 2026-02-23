namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Leopardus;

/// <summary>
/// Species: Leopardus geoffroyi
/// NCBI TaxId: 46844
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leopardus_geoffroyi : Leopardus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leopardus geoffroyi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leopardus_geoffroyi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 46844;
}
