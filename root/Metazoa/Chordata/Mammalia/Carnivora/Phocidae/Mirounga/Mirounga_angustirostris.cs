namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Mirounga;

/// <summary>
/// Species: Mirounga angustirostris
/// NCBI TaxId: 9716
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mirounga_angustirostris : Mirounga
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mirounga angustirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mirounga_angustirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9716;
}
