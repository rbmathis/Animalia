namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Peromyscus;

/// <summary>
/// Species: Peromyscus cf. hylocetes SJS-2017
/// NCBI TaxId: 2028317
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Peromyscus_cf_hylocetes_SJS_2017 : Peromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Peromyscus cf. hylocetes SJS-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Peromyscus_cf_hylocetes_SJS_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2028317;
}
