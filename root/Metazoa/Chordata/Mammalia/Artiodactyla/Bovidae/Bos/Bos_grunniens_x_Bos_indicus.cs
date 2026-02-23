namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos grunniens x Bos indicus
/// NCBI TaxId: 687163
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_grunniens_x_Bos_indicus : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos grunniens x Bos indicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_grunniens_x_Bos_indicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 687163;
}
