namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Polydactylus;

/// <summary>
/// Species: Polydactylus multiradiatus
/// NCBI TaxId: 2910461
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Polydactylus_multiradiatus : Polydactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Polydactylus multiradiatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Polydactylus_multiradiatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2910461;
}
