namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Polydactylus;

/// <summary>
/// Species: Polydactylus macrophthalmus
/// NCBI TaxId: 3359666
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Polydactylus_macrophthalmus : Polydactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Polydactylus macrophthalmus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Polydactylus_macrophthalmus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3359666;
}
