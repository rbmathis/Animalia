namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Poliocitellus;

/// <summary>
/// Species: Poliocitellus franklinii
/// NCBI TaxId: 45470
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Poliocitellus_franklinii : Poliocitellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Poliocitellus franklinii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Poliocitellus_franklinii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45470;
}
