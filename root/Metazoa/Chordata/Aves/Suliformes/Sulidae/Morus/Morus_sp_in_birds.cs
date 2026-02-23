namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae.Morus;

/// <summary>
/// Species: Morus sp. (in: birds)
/// NCBI TaxId: 2047046
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Morus_sp_in_birds : Morus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Morus sp. (in: birds)";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Morus_sp_in_birds";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2047046;
}
