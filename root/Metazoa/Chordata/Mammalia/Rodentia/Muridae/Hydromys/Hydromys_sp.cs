namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hydromys;

/// <summary>
/// Species: Hydromys sp.
/// NCBI TaxId: 3148844
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydromys_sp : Hydromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydromys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydromys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3148844;
}
