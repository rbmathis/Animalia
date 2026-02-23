namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Corvus;

/// <summary>
/// Species: Corvus unicolor
/// NCBI TaxId: 1196317
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Corvus_unicolor : Corvus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Corvus unicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Corvus_unicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1196317;
}
