namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Luperosaurus;

/// <summary>
/// Species: Luperosaurus cumingii
/// NCBI TaxId: 1183070
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Luperosaurus_cumingii : Luperosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Luperosaurus cumingii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Luperosaurus_cumingii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1183070;
}
