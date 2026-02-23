namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Ingerophrynus;

/// <summary>
/// Species: Ingerophrynus philippinicus
/// NCBI TaxId: 165227
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ingerophrynus_philippinicus : Ingerophrynus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ingerophrynus philippinicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ingerophrynus_philippinicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 165227;
}
