namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Pomacentrus;

/// <summary>
/// Species: Pomacentrus sp. n NPDP-2020
/// NCBI TaxId: 2706839
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pomacentrus_sp_n_NPDP_2020 : Pomacentrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pomacentrus sp. n NPDP-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pomacentrus_sp_n_NPDP_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2706839;
}
