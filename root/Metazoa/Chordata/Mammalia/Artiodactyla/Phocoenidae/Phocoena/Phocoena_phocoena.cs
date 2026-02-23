namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae.Phocoena;

/// <summary>
/// Species: Phocoena phocoena
/// NCBI TaxId: 9742
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phocoena_phocoena : Phocoena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phocoena phocoena";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phocoena_phocoena";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9742;
}
