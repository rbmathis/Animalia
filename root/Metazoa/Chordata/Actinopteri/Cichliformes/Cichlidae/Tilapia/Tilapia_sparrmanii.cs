namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tilapia;

/// <summary>
/// Species: Tilapia sparrmanii
/// NCBI TaxId: 64551
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tilapia_sparrmanii : Tilapia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tilapia sparrmanii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tilapia_sparrmanii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 64551;
}
