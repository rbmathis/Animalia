namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos taurus x Bos javanicus
/// NCBI TaxId: 3402570
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_taurus_x_Bos_javanicus : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos taurus x Bos javanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_taurus_x_Bos_javanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3402570;
}
