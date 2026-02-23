namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Cuculus;

/// <summary>
/// Species: Cuculus sp.
/// NCBI TaxId: 3054303
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuculus_sp : Cuculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuculus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuculus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3054303;
}
