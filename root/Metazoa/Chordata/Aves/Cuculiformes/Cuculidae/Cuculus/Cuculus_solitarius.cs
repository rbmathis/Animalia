namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Cuculus;

/// <summary>
/// Species: Cuculus solitarius
/// NCBI TaxId: 2506945
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuculus_solitarius : Cuculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuculus solitarius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuculus_solitarius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2506945;
}
