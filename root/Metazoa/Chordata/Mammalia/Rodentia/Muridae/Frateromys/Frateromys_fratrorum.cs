namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Frateromys;

/// <summary>
/// Species: Frateromys fratrorum
/// NCBI TaxId: 3049460
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Frateromys_fratrorum : Frateromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Frateromys fratrorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Frateromys_fratrorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3049460;
}
