namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Proctoporus;

/// <summary>
/// Species: Proctoporus xestus
/// NCBI TaxId: 1234257
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Proctoporus_xestus : Proctoporus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Proctoporus xestus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Proctoporus_xestus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234257;
}
