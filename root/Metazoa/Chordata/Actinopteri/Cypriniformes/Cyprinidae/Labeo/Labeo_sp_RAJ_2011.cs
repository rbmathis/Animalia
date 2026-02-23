namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeo;

/// <summary>
/// Species: Labeo sp. RAJ-2011
/// NCBI TaxId: 1268210
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Labeo_sp_RAJ_2011 : Labeo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Labeo sp. RAJ-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Labeo_sp_RAJ_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1268210;
}
