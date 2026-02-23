namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Notocitellus;

/// <summary>
/// Species: Notocitellus annulatus
/// NCBI TaxId: 99831
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Notocitellus_annulatus : Notocitellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Notocitellus annulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Notocitellus_annulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 99831;
}
