namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Cionidae.Ciona;

/// <summary>
/// Species: Ciona sp. ROS-5
/// NCBI TaxId: 1440608
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ciona_sp_ROS_5 : Ciona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ciona sp. ROS-5";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ciona_sp_ROS_5";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1440608;
}
