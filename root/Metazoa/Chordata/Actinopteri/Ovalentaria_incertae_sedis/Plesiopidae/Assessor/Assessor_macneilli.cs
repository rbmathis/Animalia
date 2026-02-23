namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Assessor;

/// <summary>
/// Species: Assessor macneilli
/// NCBI TaxId: 1647149
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Assessor_macneilli : Assessor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Assessor macneilli";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Assessor_macneilli";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1647149;
}
