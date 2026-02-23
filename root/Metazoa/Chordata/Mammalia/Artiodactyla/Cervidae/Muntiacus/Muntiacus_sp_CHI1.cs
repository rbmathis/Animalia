namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Muntiacus;

/// <summary>
/// Species: Muntiacus sp. CHI1
/// NCBI TaxId: 1954405
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Muntiacus_sp_CHI1 : Muntiacus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Muntiacus sp. CHI1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Muntiacus_sp_CHI1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1954405;
}
