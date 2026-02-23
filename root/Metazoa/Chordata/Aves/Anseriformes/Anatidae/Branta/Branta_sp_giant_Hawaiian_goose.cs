namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Branta;

/// <summary>
/// Species: Branta sp. giant Hawaiian goose
/// NCBI TaxId: 184920
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Branta_sp_giant_Hawaiian_goose : Branta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Branta sp. giant Hawaiian goose";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Branta_sp_giant_Hawaiian_goose";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 184920;
}
