namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Trogon;

/// <summary>
/// Species: Trogon rufus
/// NCBI TaxId: 59417
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trogon_rufus : Trogon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trogon rufus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trogon_rufus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59417;
}
