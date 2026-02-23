namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae.Megapodius;

/// <summary>
/// Species: Megapodius geelvinkianus
/// NCBI TaxId: 1517987
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Megapodius_geelvinkianus : Megapodius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Megapodius geelvinkianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Megapodius_geelvinkianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1517987;
}
