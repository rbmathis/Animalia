namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Genetta;

/// <summary>
/// Species: Genetta sp. pardina/'maculata' PG-2024
/// NCBI TaxId: 3126316
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Genetta_sp_pardinamaculata_PG_2024 : Genetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Genetta sp. pardina/'maculata' PG-2024";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Genetta_sp_pardinamaculata_PG_2024";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3126316;
}
