namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae.Dasyprocta;

/// <summary>
/// Species: Dasyprocta sp. 1 EG-2017
/// NCBI TaxId: 1967454
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasyprocta_sp_1_EG_2017 : Dasyprocta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasyprocta sp. 1 EG-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasyprocta_sp_1_EG_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1967454;
}
