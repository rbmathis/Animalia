namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Chamaeleo;

/// <summary>
/// Species: Chamaeleo sp.
/// NCBI TaxId: 71007
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chamaeleo_sp : Chamaeleo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chamaeleo sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chamaeleo_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 71007;
}
