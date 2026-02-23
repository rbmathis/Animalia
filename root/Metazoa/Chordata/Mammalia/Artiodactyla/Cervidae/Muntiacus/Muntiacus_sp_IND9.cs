namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Muntiacus;

/// <summary>
/// Species: Muntiacus sp. IND9
/// NCBI TaxId: 1954412
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Muntiacus_sp_IND9 : Muntiacus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Muntiacus sp. IND9";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Muntiacus_sp_IND9";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1954412;
}
