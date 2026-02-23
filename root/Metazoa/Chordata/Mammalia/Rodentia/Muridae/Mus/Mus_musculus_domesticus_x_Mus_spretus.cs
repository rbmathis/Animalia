namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus musculus domesticus x Mus spretus
/// NCBI TaxId: 2518367
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_musculus_domesticus_x_Mus_spretus : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus musculus domesticus x Mus spretus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_musculus_domesticus_x_Mus_spretus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2518367;
}
