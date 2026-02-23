namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Sarcophilus;

/// <summary>
/// Species: Sarcophilus harrisii
/// NCBI TaxId: 9305
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sarcophilus_harrisii : Sarcophilus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sarcophilus harrisii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sarcophilus_harrisii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9305;
}
