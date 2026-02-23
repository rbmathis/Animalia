namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla annectans
/// NCBI TaxId: 317325
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_annectans : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla annectans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_annectans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 317325;
}
