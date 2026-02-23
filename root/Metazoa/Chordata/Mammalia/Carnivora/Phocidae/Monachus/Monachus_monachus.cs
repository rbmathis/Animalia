namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Monachus;

/// <summary>
/// Species: Monachus monachus
/// NCBI TaxId: 248254
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Monachus_monachus : Monachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Monachus monachus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Monachus_monachus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 248254;
}
