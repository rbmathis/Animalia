namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Pomacanthus;

/// <summary>
/// Species: Pomacanthus sexstriatus
/// NCBI TaxId: 109714
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pomacanthus_sexstriatus : Pomacanthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pomacanthus sexstriatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pomacanthus_sexstriatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109714;
}
