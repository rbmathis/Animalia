namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana;

/// <summary>
/// Species: Rana cf. ornativentris
/// NCBI TaxId: 3384061
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rana_cf_ornativentris : Rana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rana cf. ornativentris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rana_cf_ornativentris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3384061;
}
