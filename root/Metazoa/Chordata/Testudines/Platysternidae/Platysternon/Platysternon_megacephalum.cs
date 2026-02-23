namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Platysternidae.Platysternon;

/// <summary>
/// Species: Platysternon megacephalum
/// NCBI TaxId: 55544
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platysternon_megacephalum : Platysternon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platysternon megacephalum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platysternon_megacephalum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 55544;
}
