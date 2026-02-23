namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Hypsugo;

/// <summary>
/// Species: Hypsugo sp. A CMF-2010
/// NCBI TaxId: 867833
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hypsugo_sp_A_CMF_2010 : Hypsugo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hypsugo sp. A CMF-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hypsugo_sp_A_CMF_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867833;
}
