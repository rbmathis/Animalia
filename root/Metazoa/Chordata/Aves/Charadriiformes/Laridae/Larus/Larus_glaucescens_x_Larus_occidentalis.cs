namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus;

/// <summary>
/// Species: Larus glaucescens x Larus occidentalis
/// NCBI TaxId: 542843
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Larus_glaucescens_x_Larus_occidentalis : Larus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Larus glaucescens x Larus occidentalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Larus_glaucescens_x_Larus_occidentalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 542843;
}
