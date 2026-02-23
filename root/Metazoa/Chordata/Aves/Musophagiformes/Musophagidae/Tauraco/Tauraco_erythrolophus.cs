namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae.Tauraco;

/// <summary>
/// Species: Tauraco erythrolophus
/// NCBI TaxId: 121530
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tauraco_erythrolophus : Tauraco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tauraco erythrolophus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tauraco_erythrolophus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121530;
}
