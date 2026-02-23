namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicaeidae.Dicaeum;

/// <summary>
/// Species: Dicaeum sanguinolentum
/// NCBI TaxId: 667165
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dicaeum_sanguinolentum : Dicaeum
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dicaeum sanguinolentum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dicaeum_sanguinolentum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 667165;
}
