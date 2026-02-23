namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamias;

/// <summary>
/// Species: Tamias amoenus x Tamias ruficaudus
/// NCBI TaxId: 231237
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tamias_amoenus_x_Tamias_ruficaudus : Tamias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tamias amoenus x Tamias ruficaudus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tamias_amoenus_x_Tamias_ruficaudus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 231237;
}
