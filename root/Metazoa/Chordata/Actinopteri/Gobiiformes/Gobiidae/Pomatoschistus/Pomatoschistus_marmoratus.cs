namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pomatoschistus;

/// <summary>
/// Species: Pomatoschistus marmoratus
/// NCBI TaxId: 85419
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pomatoschistus_marmoratus : Pomatoschistus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pomatoschistus marmoratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pomatoschistus_marmoratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 85419;
}
