namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.Arapaima;

/// <summary>
/// Species: Arapaima sp. 'Guyana arapaima'
/// NCBI TaxId: 1494646
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Arapaima_sp_Guyana_arapaima : Arapaima
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Arapaima sp. 'Guyana arapaima'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Arapaima_sp_Guyana_arapaima";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1494646;
}
