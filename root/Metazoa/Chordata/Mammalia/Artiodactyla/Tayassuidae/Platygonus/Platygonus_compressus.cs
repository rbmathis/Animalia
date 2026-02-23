namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae.Platygonus;

/// <summary>
/// Species: Platygonus compressus
/// NCBI TaxId: 1983451
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platygonus_compressus : Platygonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platygonus compressus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platygonus_compressus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1983451;
}
