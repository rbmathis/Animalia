namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Liolaemus;

/// <summary>
/// Species: Liolaemus sp. C CDM-2014
/// NCBI TaxId: 1590180
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Liolaemus_sp_C_CDM_2014 : Liolaemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Liolaemus sp. C CDM-2014";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Liolaemus_sp_C_CDM_2014";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1590180;
}
