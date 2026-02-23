namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo marmoratus x Salmo trutta
/// NCBI TaxId: 1509524
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_marmoratus_x_Salmo_trutta : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo marmoratus x Salmo trutta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_marmoratus_x_Salmo_trutta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1509524;
}
