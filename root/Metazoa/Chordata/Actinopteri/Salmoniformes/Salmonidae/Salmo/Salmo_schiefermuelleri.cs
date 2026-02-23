namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo schiefermuelleri
/// NCBI TaxId: 3360568
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_schiefermuelleri : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo schiefermuelleri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_schiefermuelleri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3360568;
}
