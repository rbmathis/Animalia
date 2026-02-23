namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Peromyscus;

/// <summary>
/// Species: Peromyscus cf. guatemalensis SGP-2014
/// NCBI TaxId: 1588035
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Peromyscus_cf_guatemalensis_SGP_2014 : Peromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Peromyscus cf. guatemalensis SGP-2014";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Peromyscus_cf_guatemalensis_SGP_2014";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1588035;
}
