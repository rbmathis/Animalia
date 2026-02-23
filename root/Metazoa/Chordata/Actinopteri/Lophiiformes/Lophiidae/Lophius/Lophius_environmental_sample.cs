namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Lophius;

/// <summary>
/// Species: Lophius environmental sample
/// NCBI TaxId: 1814135
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lophius_environmental_sample : Lophius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lophius environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lophius_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814135;
}
