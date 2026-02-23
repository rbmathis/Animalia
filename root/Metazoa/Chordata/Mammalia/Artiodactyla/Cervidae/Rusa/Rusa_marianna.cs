namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Rusa;

/// <summary>
/// Species: Rusa marianna
/// NCBI TaxId: 1826171
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rusa_marianna : Rusa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rusa marianna";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rusa_marianna";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1826171;
}
