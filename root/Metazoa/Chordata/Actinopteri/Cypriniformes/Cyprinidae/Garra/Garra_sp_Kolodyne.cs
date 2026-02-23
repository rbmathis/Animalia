namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Garra;

/// <summary>
/// Species: Garra sp. Kolodyne
/// NCBI TaxId: 1390389
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Garra_sp_Kolodyne : Garra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Garra sp. Kolodyne";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Garra_sp_Kolodyne";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1390389;
}
