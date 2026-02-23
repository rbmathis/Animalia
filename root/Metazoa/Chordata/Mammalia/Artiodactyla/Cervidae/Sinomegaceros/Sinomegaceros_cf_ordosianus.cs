namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Sinomegaceros;

/// <summary>
/// Species: Sinomegaceros cf. ordosianus
/// NCBI TaxId: 3104232
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sinomegaceros_cf_ordosianus : Sinomegaceros
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sinomegaceros cf. ordosianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sinomegaceros_cf_ordosianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3104232;
}
