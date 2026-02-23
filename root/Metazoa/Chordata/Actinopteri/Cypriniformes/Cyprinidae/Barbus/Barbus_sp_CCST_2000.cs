namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Barbus;

/// <summary>
/// Species: Barbus sp. CCST-2000
/// NCBI TaxId: 137770
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Barbus_sp_CCST_2000 : Barbus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Barbus sp. CCST-2000";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Barbus_sp_CCST_2000";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 137770;
}
