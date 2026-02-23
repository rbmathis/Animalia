namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phyllomedusa;

/// <summary>
/// Species: Phyllomedusa sauvagii
/// NCBI TaxId: 8395
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllomedusa_sauvagii : Phyllomedusa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllomedusa sauvagii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllomedusa_sauvagii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8395;
}
