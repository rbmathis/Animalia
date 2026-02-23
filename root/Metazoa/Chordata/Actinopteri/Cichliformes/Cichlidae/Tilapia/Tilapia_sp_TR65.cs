namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tilapia;

/// <summary>
/// Species: Tilapia sp. TR65
/// NCBI TaxId: 1587908
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tilapia_sp_TR65 : Tilapia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tilapia sp. TR65";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tilapia_sp_TR65";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1587908;
}
