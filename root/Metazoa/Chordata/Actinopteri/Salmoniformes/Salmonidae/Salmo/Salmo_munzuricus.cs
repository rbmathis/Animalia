namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo munzuricus
/// NCBI TaxId: 2739738
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_munzuricus : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo munzuricus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_munzuricus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2739738;
}
