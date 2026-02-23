namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nephelomys;

/// <summary>
/// Species: Nephelomys albigularis
/// NCBI TaxId: 530178
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nephelomys_albigularis : Nephelomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nephelomys albigularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nephelomys_albigularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 530178;
}
