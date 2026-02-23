namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus;

/// <summary>
/// Species: Larus fuscus
/// NCBI TaxId: 8915
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Larus_fuscus : Larus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Larus fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Larus_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8915;
}
