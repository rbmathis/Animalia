namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Mesoplodon;

/// <summary>
/// Species: Mesoplodon peruvianus
/// NCBI TaxId: 27617
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesoplodon_peruvianus : Mesoplodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesoplodon peruvianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesoplodon_peruvianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27617;
}
