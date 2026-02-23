namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Polydactylus;

/// <summary>
/// Species: Polydactylus virginicus
/// NCBI TaxId: 1154659
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Polydactylus_virginicus : Polydactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Polydactylus virginicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Polydactylus_virginicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1154659;
}
