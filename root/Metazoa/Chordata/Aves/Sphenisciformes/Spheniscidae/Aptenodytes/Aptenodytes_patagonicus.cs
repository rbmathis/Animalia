namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Aptenodytes;

/// <summary>
/// Species: Aptenodytes patagonicus
/// NCBI TaxId: 9234
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aptenodytes_patagonicus : Aptenodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aptenodytes patagonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aptenodytes_patagonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9234;
}
