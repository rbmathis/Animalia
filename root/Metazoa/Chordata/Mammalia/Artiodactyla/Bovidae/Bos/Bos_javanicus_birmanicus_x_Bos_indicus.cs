namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos javanicus birmanicus x Bos indicus
/// NCBI TaxId: 661048
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_javanicus_birmanicus_x_Bos_indicus : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos javanicus birmanicus x Bos indicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_javanicus_birmanicus_x_Bos_indicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 661048;
}
