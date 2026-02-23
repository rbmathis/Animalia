namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pitohui;

/// <summary>
/// Species: Pitohui uropygialis
/// NCBI TaxId: 2305099
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pitohui_uropygialis : Pitohui
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pitohui uropygialis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pitohui_uropygialis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2305099;
}
