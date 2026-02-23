namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko japonicus x Gekko sp.
/// NCBI TaxId: 3360073
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_japonicus_x_Gekko_sp : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko japonicus x Gekko sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_japonicus_x_Gekko_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3360073;
}
