namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Herpestes;

/// <summary>
/// Species: Herpestes fuscus
/// NCBI TaxId: 643830
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Herpestes_fuscus : Herpestes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Herpestes fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Herpestes_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 643830;
}
