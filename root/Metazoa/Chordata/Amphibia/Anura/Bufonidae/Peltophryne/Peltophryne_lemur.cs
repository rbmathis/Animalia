namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Peltophryne;

/// <summary>
/// Species: Peltophryne lemur
/// NCBI TaxId: 47586
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Peltophryne_lemur : Peltophryne
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Peltophryne lemur";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Peltophryne_lemur";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 47586;
}
