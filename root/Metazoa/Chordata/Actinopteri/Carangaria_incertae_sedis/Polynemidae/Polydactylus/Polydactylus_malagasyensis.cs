namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Polydactylus;

/// <summary>
/// Species: Polydactylus malagasyensis
/// NCBI TaxId: 1003785
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Polydactylus_malagasyensis : Polydactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Polydactylus malagasyensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Polydactylus_malagasyensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1003785;
}
