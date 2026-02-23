namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo trutta
/// NCBI TaxId: 8032
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_trutta : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo trutta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_trutta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8032;
}
