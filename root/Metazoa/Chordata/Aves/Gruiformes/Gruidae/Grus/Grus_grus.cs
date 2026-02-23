namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Grus;

/// <summary>
/// Species: Grus grus
/// NCBI TaxId: 40816
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Grus_grus : Grus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Grus grus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Grus_grus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 40816;
}
