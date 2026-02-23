namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae.Parahyaena;

/// <summary>
/// Species: Parahyaena brunnea
/// NCBI TaxId: 172271
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parahyaena_brunnea : Parahyaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parahyaena brunnea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parahyaena_brunnea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 172271;
}
