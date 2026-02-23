namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Ramphastos;

/// <summary>
/// Species: Ramphastos swainsonii
/// NCBI TaxId: 207748
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ramphastos_swainsonii : Ramphastos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ramphastos swainsonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ramphastos_swainsonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 207748;
}
