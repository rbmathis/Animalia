namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Nyctibiiformes.Nyctibiidae.Nyctibius;

/// <summary>
/// Species: Nyctibius maculosus
/// NCBI TaxId: 48430
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctibius_maculosus : Nyctibius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctibius maculosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctibius_maculosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48430;
}
