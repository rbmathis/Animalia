namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Hypseleotris;

/// <summary>
/// Species: Hypseleotris sp. HA
/// NCBI TaxId: 1070325
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hypseleotris_sp_HA : Hypseleotris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hypseleotris sp. HA";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hypseleotris_sp_HA";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1070325;
}
