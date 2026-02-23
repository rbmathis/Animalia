namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Boops;

/// <summary>
/// Species: Boops environmental sample
/// NCBI TaxId: 1814130
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Boops_environmental_sample : Boops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Boops environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Boops_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814130;
}
