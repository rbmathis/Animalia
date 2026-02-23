namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Muntiacus;

/// <summary>
/// Species: Muntiacus rooseveltorum
/// NCBI TaxId: 109295
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Muntiacus_rooseveltorum : Muntiacus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Muntiacus rooseveltorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Muntiacus_rooseveltorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109295;
}
