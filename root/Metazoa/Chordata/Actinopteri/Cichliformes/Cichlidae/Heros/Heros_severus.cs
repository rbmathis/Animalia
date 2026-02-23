namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Heros;

/// <summary>
/// Species: Heros severus
/// NCBI TaxId: 238233
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heros_severus : Heros
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heros severus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heros_severus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 238233;
}
