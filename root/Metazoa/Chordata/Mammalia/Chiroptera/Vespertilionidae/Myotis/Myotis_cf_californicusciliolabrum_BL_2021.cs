namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis cf. californicus/ciliolabrum BL-2021
/// NCBI TaxId: 2891921
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_cf_californicusciliolabrum_BL_2021 : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis cf. californicus/ciliolabrum BL-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_cf_californicusciliolabrum_BL_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2891921;
}
