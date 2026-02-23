namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Lanio;

/// <summary>
/// Species: Lanio fulvus
/// NCBI TaxId: 548484
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lanio_fulvus : Lanio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lanio fulvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lanio_fulvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 548484;
}
