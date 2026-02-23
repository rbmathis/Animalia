namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo cenerinus
/// NCBI TaxId: 1483119
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_cenerinus : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo cenerinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_cenerinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1483119;
}
