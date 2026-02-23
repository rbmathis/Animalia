namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tilapia;

/// <summary>
/// Species: Tilapia brevimanus
/// NCBI TaxId: 158772
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tilapia_brevimanus : Tilapia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tilapia brevimanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tilapia_brevimanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 158772;
}
