namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Coraciidae.Coracias;

/// <summary>
/// Species: Coracias abyssinicus
/// NCBI TaxId: 325342
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coracias_abyssinicus : Coracias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coracias abyssinicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coracias_abyssinicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 325342;
}
