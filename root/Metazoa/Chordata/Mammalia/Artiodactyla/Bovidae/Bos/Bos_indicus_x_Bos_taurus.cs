namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos indicus x Bos taurus
/// NCBI TaxId: 30522
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_indicus_x_Bos_taurus : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos indicus x Bos taurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_indicus_x_Bos_taurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30522;
}
