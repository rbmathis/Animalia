namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pituophis;

/// <summary>
/// Species: Pituophis lineaticollis
/// NCBI TaxId: 94862
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pituophis_lineaticollis : Pituophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pituophis lineaticollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pituophis_lineaticollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 94862;
}
