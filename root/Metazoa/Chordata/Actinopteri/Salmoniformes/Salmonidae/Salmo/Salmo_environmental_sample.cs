namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo environmental sample
/// NCBI TaxId: 1814142
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_environmental_sample : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814142;
}
