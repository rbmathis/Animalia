namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Procyon;

/// <summary>
/// Species: Procyon environmental sample
/// NCBI TaxId: 1002251
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Procyon_environmental_sample : Procyon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Procyon environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Procyon_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002251;
}
