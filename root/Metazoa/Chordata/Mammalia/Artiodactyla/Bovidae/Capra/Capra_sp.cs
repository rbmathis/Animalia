namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capra;

/// <summary>
/// Species: Capra sp.
/// NCBI TaxId: 61294
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capra_sp : Capra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capra sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capra_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61294;
}
