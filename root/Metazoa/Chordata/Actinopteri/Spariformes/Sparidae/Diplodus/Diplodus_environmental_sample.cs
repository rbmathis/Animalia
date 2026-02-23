namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Diplodus;

/// <summary>
/// Species: Diplodus environmental sample
/// NCBI TaxId: 1814132
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Diplodus_environmental_sample : Diplodus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Diplodus environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Diplodus_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814132;
}
