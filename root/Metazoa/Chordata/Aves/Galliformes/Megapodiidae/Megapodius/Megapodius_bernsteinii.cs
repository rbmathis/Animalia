namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae.Megapodius;

/// <summary>
/// Species: Megapodius bernsteinii
/// NCBI TaxId: 1517986
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Megapodius_bernsteinii : Megapodius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Megapodius bernsteinii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Megapodius_bernsteinii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1517986;
}
