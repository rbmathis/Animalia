namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Otopharynx;

/// <summary>
/// Species: Otopharynx sp. 'productus'
/// NCBI TaxId: 1075424
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otopharynx_sp_productus : Otopharynx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otopharynx sp. 'productus'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otopharynx_sp_productus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1075424;
}
