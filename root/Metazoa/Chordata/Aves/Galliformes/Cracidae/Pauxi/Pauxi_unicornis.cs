namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Pauxi;

/// <summary>
/// Species: Pauxi unicornis
/// NCBI TaxId: 210763
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pauxi_unicornis : Pauxi
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pauxi unicornis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pauxi_unicornis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 210763;
}
