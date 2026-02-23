namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Micromys;

/// <summary>
/// Species: Micromys sp. y ZL-2021
/// NCBI TaxId: 2898792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Micromys_sp_y_ZL_2021 : Micromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Micromys sp. y ZL-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Micromys_sp_y_ZL_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2898792;
}
