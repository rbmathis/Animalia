namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos sp. BXL006
/// NCBI TaxId: 2706544
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_sp_BXL006 : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos sp. BXL006";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_sp_BXL006";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2706544;
}
