namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo sp. SILVA_04
/// NCBI TaxId: 2830112
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_sp_SILVA_04 : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo sp. SILVA_04";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_sp_SILVA_04";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2830112;
}
