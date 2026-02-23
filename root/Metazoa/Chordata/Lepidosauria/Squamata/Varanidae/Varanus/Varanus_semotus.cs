namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus semotus
/// NCBI TaxId: 1840423
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_semotus : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus semotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_semotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1840423;
}
