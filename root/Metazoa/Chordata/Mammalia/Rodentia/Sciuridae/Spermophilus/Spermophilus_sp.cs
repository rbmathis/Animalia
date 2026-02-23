namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Spermophilus;

/// <summary>
/// Species: Spermophilus sp.
/// NCBI TaxId: 99849
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spermophilus_sp : Spermophilus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spermophilus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spermophilus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 99849;
}
