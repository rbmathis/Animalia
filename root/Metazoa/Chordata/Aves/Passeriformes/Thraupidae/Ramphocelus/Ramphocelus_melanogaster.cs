namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Ramphocelus;

/// <summary>
/// Species: Ramphocelus melanogaster
/// NCBI TaxId: 664763
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ramphocelus_melanogaster : Ramphocelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ramphocelus melanogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ramphocelus_melanogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 664763;
}
