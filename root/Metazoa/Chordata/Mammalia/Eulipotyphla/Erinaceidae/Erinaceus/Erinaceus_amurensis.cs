namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Erinaceus;

/// <summary>
/// Species: Erinaceus amurensis
/// NCBI TaxId: 757341
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Erinaceus_amurensis : Erinaceus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Erinaceus amurensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Erinaceus_amurensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 757341;
}
