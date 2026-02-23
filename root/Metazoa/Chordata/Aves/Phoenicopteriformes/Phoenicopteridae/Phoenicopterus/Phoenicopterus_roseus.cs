namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae.Phoenicopterus;

/// <summary>
/// Species: Phoenicopterus roseus
/// NCBI TaxId: 435638
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phoenicopterus_roseus : Phoenicopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phoenicopterus roseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phoenicopterus_roseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 435638;
}
