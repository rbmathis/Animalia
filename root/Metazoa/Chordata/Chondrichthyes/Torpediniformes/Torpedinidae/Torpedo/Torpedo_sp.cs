namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Torpedo;

/// <summary>
/// Species: Torpedo sp.
/// NCBI TaxId: 70732
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Torpedo_sp : Torpedo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Torpedo sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Torpedo_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 70732;
}
