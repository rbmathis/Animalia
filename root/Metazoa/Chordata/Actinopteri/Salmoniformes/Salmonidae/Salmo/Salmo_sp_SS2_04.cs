namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo sp. SS2_04
/// NCBI TaxId: 2830122
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_sp_SS2_04 : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo sp. SS2_04";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_sp_SS2_04";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2830122;
}
