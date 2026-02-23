namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae.Hipposideros;

/// <summary>
/// Species: Hipposideros cf. larvatus
/// NCBI TaxId: 3117227
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hipposideros_cf_larvatus : Hipposideros
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hipposideros cf. larvatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hipposideros_cf_larvatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3117227;
}
