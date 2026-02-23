namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Mesoplodon;

/// <summary>
/// Species: Mesoplodon hotaula
/// NCBI TaxId: 1234366
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesoplodon_hotaula : Mesoplodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesoplodon hotaula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesoplodon_hotaula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234366;
}
