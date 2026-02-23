namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Branta;

/// <summary>
/// Species: Branta sp. BW-2011
/// NCBI TaxId: 993691
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Branta_sp_BW_2011 : Branta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Branta sp. BW-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Branta_sp_BW_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 993691;
}
