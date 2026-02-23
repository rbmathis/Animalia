namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pseudomys;

/// <summary>
/// Species: Pseudomys novaehollandiae
/// NCBI TaxId: 442614
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudomys_novaehollandiae : Pseudomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudomys novaehollandiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudomys_novaehollandiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 442614;
}
