namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Thomasomys;

/// <summary>
/// Species: Thomasomys aff. cinereus
/// NCBI TaxId: 3144140
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thomasomys_aff_cinereus : Thomasomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thomasomys aff. cinereus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thomasomys_aff_cinereus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3144140;
}
