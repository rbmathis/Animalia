namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Plecotus;

/// <summary>
/// Species: Plecotus teneriffae
/// NCBI TaxId: 187391
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Plecotus_teneriffae : Plecotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Plecotus teneriffae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Plecotus_teneriffae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 187391;
}
