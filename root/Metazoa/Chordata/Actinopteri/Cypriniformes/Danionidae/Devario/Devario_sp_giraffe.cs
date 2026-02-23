namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Devario;

/// <summary>
/// Species: Devario sp. 'giraffe'
/// NCBI TaxId: 1093600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Devario_sp_giraffe : Devario
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Devario sp. 'giraffe'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Devario_sp_giraffe";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1093600;
}
