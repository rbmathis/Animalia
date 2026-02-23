namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Grus;

/// <summary>
/// Species: Grus americana
/// NCBI TaxId: 9117
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Grus_americana : Grus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Grus americana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Grus_americana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9117;
}
