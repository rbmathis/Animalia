namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Urocitellus;

/// <summary>
/// Species: Urocitellus townsendii
/// NCBI TaxId: 99861
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Urocitellus_townsendii : Urocitellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Urocitellus townsendii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Urocitellus_townsendii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 99861;
}
