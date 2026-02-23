namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Uromys;

/// <summary>
/// Species: Uromys sp.
/// NCBI TaxId: 3148846
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Uromys_sp : Uromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Uromys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Uromys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3148846;
}
