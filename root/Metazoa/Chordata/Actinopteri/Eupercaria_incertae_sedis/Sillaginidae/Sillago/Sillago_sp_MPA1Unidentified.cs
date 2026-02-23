namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillago;

/// <summary>
/// Species: Sillago sp. MPA1/Unidentified
/// NCBI TaxId: 3027001
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sillago_sp_MPA1Unidentified : Sillago
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sillago sp. MPA1/Unidentified";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sillago_sp_MPA1Unidentified";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3027001;
}
