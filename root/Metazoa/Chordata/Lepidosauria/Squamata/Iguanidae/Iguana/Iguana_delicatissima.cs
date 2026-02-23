namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Iguana;

/// <summary>
/// Species: Iguana delicatissima
/// NCBI TaxId: 51191
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Iguana_delicatissima : Iguana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Iguana delicatissima";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Iguana_delicatissima";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51191;
}
