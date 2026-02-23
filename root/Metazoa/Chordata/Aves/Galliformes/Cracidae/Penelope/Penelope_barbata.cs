namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Penelope;

/// <summary>
/// Species: Penelope barbata
/// NCBI TaxId: 1109085
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Penelope_barbata : Penelope
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Penelope barbata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Penelope_barbata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1109085;
}
