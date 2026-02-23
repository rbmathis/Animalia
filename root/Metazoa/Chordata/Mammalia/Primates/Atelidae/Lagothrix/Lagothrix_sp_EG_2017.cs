namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Lagothrix;

/// <summary>
/// Species: Lagothrix sp. EG-2017
/// NCBI TaxId: 1967456
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lagothrix_sp_EG_2017 : Lagothrix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lagothrix sp. EG-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lagothrix_sp_EG_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1967456;
}
