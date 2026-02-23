namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Glaucomys;

/// <summary>
/// Species: Glaucomys oregonensis
/// NCBI TaxId: 84766
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Glaucomys_oregonensis : Glaucomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Glaucomys oregonensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Glaucomys_oregonensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 84766;
}
