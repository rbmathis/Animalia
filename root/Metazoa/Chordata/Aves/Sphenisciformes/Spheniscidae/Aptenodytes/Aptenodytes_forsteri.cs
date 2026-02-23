namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Aptenodytes;

/// <summary>
/// Species: Aptenodytes forsteri
/// NCBI TaxId: 9233
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aptenodytes_forsteri : Aptenodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aptenodytes forsteri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aptenodytes_forsteri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9233;
}
