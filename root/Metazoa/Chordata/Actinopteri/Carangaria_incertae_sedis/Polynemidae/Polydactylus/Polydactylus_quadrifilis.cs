namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Polydactylus;

/// <summary>
/// Species: Polydactylus quadrifilis
/// NCBI TaxId: 2910464
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Polydactylus_quadrifilis : Polydactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Polydactylus quadrifilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Polydactylus_quadrifilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2910464;
}
