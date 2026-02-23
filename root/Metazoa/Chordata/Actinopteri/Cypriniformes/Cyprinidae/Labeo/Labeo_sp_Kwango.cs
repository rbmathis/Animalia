namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeo;

/// <summary>
/// Species: Labeo sp. 'Kwango'
/// NCBI TaxId: 2952485
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Labeo_sp_Kwango : Labeo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Labeo sp. 'Kwango'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Labeo_sp_Kwango";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2952485;
}
