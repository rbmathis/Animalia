namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Malacomys;

/// <summary>
/// Species: Malacomys cansdalei
/// NCBI TaxId: 1001554
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Malacomys_cansdalei : Malacomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Malacomys cansdalei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Malacomys_cansdalei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1001554;
}
