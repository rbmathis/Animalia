namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pituophis;

/// <summary>
/// Species: Pituophis melanoleucus
/// NCBI TaxId: 8595
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pituophis_melanoleucus : Pituophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pituophis melanoleucus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pituophis_melanoleucus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8595;
}
