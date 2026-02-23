namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Saurida;

/// <summary>
/// Species: Saurida sp. RACB
/// NCBI TaxId: 3408577
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saurida_sp_RACB : Saurida
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saurida sp. RACB";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saurida_sp_RACB";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3408577;
}
