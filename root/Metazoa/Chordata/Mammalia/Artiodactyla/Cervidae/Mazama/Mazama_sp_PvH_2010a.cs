namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Mazama;

/// <summary>
/// Species: Mazama sp. PvH-2010a
/// NCBI TaxId: 760193
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mazama_sp_PvH_2010a : Mazama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mazama sp. PvH-2010a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mazama_sp_PvH_2010a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 760193;
}
