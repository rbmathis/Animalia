namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Katsuwonus;

/// <summary>
/// Species: Katsuwonus pelamis
/// NCBI TaxId: 8226
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Katsuwonus_pelamis : Katsuwonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Katsuwonus pelamis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Katsuwonus_pelamis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8226;
}
