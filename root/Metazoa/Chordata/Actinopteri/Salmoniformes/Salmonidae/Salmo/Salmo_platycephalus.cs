namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo platycephalus
/// NCBI TaxId: 235141
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_platycephalus : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo platycephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_platycephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 235141;
}
