namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus sp. indet. Clade65
/// NCBI TaxId: 2941063
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_sp_indet_Clade65 : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus sp. indet. Clade65";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_sp_indet_Clade65";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2941063;
}
