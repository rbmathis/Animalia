namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Clonophis;

/// <summary>
/// Species: Clonophis kirtlandii
/// NCBI TaxId: 183600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clonophis_kirtlandii : Clonophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clonophis kirtlandii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clonophis_kirtlandii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 183600;
}
