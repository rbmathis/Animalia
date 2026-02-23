namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Puffinus;

/// <summary>
/// Species: Puffinus kermadecensis
/// NCBI TaxId: 232340
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Puffinus_kermadecensis : Puffinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Puffinus kermadecensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Puffinus_kermadecensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 232340;
}
