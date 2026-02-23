namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobius;

/// <summary>
/// Species: Gobius environmental sample
/// NCBI TaxId: 1793145
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gobius_environmental_sample : Gobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gobius environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gobius_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1793145;
}
