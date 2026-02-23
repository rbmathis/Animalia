namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Sander;

/// <summary>
/// Species: Sander lucioperca
/// NCBI TaxId: 283035
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sander_lucioperca : Sander
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sander lucioperca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sander_lucioperca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 283035;
}
