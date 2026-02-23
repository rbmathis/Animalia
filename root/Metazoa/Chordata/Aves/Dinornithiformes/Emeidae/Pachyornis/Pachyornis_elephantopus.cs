namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Emeidae.Pachyornis;

/// <summary>
/// Species: Pachyornis elephantopus
/// NCBI TaxId: 8815
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachyornis_elephantopus : Pachyornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachyornis elephantopus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachyornis_elephantopus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8815;
}
