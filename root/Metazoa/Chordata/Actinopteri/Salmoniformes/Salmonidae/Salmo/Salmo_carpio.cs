namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo carpio
/// NCBI TaxId: 33515
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_carpio : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo carpio";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_carpio";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33515;
}
