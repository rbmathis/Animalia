namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Grus;

/// <summary>
/// Species: Grus carunculatus
/// NCBI TaxId: 9118
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Grus_carunculatus : Grus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Grus carunculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Grus_carunculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9118;
}
