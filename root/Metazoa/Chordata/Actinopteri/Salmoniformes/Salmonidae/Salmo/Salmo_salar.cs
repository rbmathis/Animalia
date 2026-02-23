namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo salar
/// NCBI TaxId: 8030
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_salar : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo salar";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_salar";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8030;
}
