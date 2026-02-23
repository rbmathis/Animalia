namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Talpa;

/// <summary>
/// Species: Talpa sp. BA-2017
/// NCBI TaxId: 1983367
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Talpa_sp_BA_2017 : Talpa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Talpa sp. BA-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Talpa_sp_BA_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1983367;
}
