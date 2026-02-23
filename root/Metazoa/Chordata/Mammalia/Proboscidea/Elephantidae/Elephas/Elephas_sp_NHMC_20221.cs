namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Elephas;

/// <summary>
/// Species: Elephas sp. NHMC 20.2.2.1
/// NCBI TaxId: 363580
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elephas_sp_NHMC_20221 : Elephas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elephas sp. NHMC 20.2.2.1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elephas_sp_NHMC_20221";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 363580;
}
