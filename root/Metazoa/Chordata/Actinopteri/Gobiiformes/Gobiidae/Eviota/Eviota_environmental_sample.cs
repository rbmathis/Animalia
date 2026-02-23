namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eviota;

/// <summary>
/// Species: Eviota environmental sample
/// NCBI TaxId: 1069892
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eviota_environmental_sample : Eviota
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eviota environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eviota_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1069892;
}
