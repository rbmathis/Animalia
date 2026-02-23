namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taeromys;

/// <summary>
/// Species: Taeromys sp. n. HH-2020
/// NCBI TaxId: 2783997
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Taeromys_sp_n_HH_2020 : Taeromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Taeromys sp. n. HH-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Taeromys_sp_n_HH_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2783997;
}
