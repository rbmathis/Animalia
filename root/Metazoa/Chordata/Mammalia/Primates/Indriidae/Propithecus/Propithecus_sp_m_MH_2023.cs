namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Propithecus;

/// <summary>
/// Species: Propithecus sp. m MH-2023
/// NCBI TaxId: 3092528
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Propithecus_sp_m_MH_2023 : Propithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Propithecus sp. m MH-2023";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Propithecus_sp_m_MH_2023";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3092528;
}
