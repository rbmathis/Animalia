namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Nasuella;

/// <summary>
/// Species: Nasuella olivacea
/// NCBI TaxId: 743424
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nasuella_olivacea : Nasuella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nasuella olivacea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nasuella_olivacea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 743424;
}
