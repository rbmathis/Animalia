namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo marmoratus
/// NCBI TaxId: 33518
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_marmoratus : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo marmoratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_marmoratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33518;
}
