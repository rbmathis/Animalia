namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Torpedo;

/// <summary>
/// Species: Torpedo marmorata
/// NCBI TaxId: 7788
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Torpedo_marmorata : Torpedo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Torpedo marmorata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Torpedo_marmorata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7788;
}
