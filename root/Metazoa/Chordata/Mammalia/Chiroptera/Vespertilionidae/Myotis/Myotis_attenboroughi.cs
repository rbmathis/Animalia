namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis attenboroughi
/// NCBI TaxId: 2940077
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_attenboroughi : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis attenboroughi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_attenboroughi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2940077;
}
