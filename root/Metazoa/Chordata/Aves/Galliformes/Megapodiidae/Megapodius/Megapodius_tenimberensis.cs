namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae.Megapodius;

/// <summary>
/// Species: Megapodius tenimberensis
/// NCBI TaxId: 177170
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Megapodius_tenimberensis : Megapodius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Megapodius tenimberensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Megapodius_tenimberensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 177170;
}
