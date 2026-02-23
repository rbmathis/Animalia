namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Grus;

/// <summary>
/// Species: Grus sp.
/// NCBI TaxId: 182212
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Grus_sp : Grus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Grus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Grus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 182212;
}
