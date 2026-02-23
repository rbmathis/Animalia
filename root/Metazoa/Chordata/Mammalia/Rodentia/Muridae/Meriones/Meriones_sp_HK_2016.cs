namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Meriones;

/// <summary>
/// Species: Meriones sp. HK-2016
/// NCBI TaxId: 1788385
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Meriones_sp_HK_2016 : Meriones
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Meriones sp. HK-2016";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Meriones_sp_HK_2016";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1788385;
}
