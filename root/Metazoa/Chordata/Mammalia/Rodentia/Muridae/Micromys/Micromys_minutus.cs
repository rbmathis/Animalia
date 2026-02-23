namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Micromys;

/// <summary>
/// Species: Micromys minutus
/// NCBI TaxId: 13151
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Micromys_minutus : Micromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Micromys minutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Micromys_minutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13151;
}
