namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Amphistichus;

/// <summary>
/// Species: Amphistichus argenteus
/// NCBI TaxId: 100186
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphistichus_argenteus : Amphistichus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphistichus argenteus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphistichus_argenteus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100186;
}
