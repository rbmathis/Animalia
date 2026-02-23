namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis cf. ater CMF-2010
/// NCBI TaxId: 867855
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_cf_ater_CMF_2010 : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis cf. ater CMF-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_cf_ater_CMF_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867855;
}
