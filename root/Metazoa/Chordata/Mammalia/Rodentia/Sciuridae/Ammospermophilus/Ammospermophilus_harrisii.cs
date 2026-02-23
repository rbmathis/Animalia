namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Ammospermophilus;

/// <summary>
/// Species: Ammospermophilus harrisii
/// NCBI TaxId: 45487
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ammospermophilus_harrisii : Ammospermophilus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ammospermophilus harrisii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ammospermophilus_harrisii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45487;
}
