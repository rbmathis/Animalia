namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Micromys;

/// <summary>
/// Species: Micromys pygmaeus
/// NCBI TaxId: 3242100
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Micromys_pygmaeus : Micromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Micromys pygmaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Micromys_pygmaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3242100;
}
