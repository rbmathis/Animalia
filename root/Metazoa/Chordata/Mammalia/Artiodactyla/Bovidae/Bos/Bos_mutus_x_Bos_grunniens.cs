namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos mutus x Bos grunniens
/// NCBI TaxId: 2777923
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_mutus_x_Bos_grunniens : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos mutus x Bos grunniens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_mutus_x_Bos_grunniens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2777923;
}
