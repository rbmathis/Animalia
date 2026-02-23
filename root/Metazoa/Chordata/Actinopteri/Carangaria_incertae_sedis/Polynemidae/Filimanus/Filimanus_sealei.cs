namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Filimanus;

/// <summary>
/// Species: Filimanus sealei
/// NCBI TaxId: 2202271
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Filimanus_sealei : Filimanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Filimanus sealei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Filimanus_sealei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2202271;
}
