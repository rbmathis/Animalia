namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Rupicapra;

/// <summary>
/// Species: Rupicapra sp. mtC1
/// NCBI TaxId: 2022397
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rupicapra_sp_mtC1 : Rupicapra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rupicapra sp. mtC1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rupicapra_sp_mtC1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2022397;
}
