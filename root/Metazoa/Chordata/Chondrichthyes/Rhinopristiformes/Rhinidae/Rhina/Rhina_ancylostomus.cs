namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinidae.Rhina;

/// <summary>
/// Species: Rhina ancylostomus
/// NCBI TaxId: 3025902
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhina_ancylostomus : Rhina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhina ancylostomus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhina_ancylostomus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3025902;
}
