namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Gadus;

/// <summary>
/// Species: Gadus morhua
/// NCBI TaxId: 8049
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gadus_morhua : Gadus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gadus morhua";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gadus_morhua";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8049;
}
