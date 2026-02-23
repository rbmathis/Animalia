namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Urocitellus;

/// <summary>
/// Species: Urocitellus undulatus
/// NCBI TaxId: 99867
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Urocitellus_undulatus : Urocitellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Urocitellus undulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Urocitellus_undulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 99867;
}
