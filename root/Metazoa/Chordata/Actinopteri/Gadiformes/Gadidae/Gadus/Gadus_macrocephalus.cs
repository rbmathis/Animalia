namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Gadus;

/// <summary>
/// Species: Gadus macrocephalus
/// NCBI TaxId: 80720
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gadus_macrocephalus : Gadus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gadus macrocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gadus_macrocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 80720;
}
