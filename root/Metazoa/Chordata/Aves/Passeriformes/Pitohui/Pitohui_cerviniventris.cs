namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pitohui;

/// <summary>
/// Species: Pitohui cerviniventris
/// NCBI TaxId: 3150339
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pitohui_cerviniventris : Pitohui
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pitohui cerviniventris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pitohui_cerviniventris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150339;
}
