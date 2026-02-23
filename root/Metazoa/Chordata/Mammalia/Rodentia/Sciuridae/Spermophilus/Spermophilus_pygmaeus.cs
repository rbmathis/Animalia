namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Spermophilus;

/// <summary>
/// Species: Spermophilus pygmaeus
/// NCBI TaxId: 99855
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spermophilus_pygmaeus : Spermophilus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spermophilus pygmaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spermophilus_pygmaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 99855;
}
