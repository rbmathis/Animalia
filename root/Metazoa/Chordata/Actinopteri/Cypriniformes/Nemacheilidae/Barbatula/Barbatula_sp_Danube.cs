namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Barbatula;

/// <summary>
/// Species: Barbatula sp. Danube
/// NCBI TaxId: 1824537
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Barbatula_sp_Danube : Barbatula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Barbatula sp. Danube";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Barbatula_sp_Danube";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1824537;
}
