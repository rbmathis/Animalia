namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Tockus;

/// <summary>
/// Species: Tockus alboterminatus
/// NCBI TaxId: 3150082
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tockus_alboterminatus : Tockus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tockus alboterminatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tockus_alboterminatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150082;
}
