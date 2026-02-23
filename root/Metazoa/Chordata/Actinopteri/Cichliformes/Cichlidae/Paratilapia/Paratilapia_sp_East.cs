namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paratilapia;

/// <summary>
/// Species: Paratilapia sp. 'East'
/// NCBI TaxId: 302992
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paratilapia_sp_East : Paratilapia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paratilapia sp. 'East'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paratilapia_sp_East";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 302992;
}
