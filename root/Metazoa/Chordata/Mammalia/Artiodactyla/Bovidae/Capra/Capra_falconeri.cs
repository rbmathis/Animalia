namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capra;

/// <summary>
/// Species: Capra falconeri
/// NCBI TaxId: 48167
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capra_falconeri : Capra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capra falconeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capra_falconeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48167;
}
