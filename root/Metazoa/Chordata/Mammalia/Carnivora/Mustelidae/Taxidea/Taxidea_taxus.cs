namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Taxidea;

/// <summary>
/// Species: Taxidea taxus
/// NCBI TaxId: 30554
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Taxidea_taxus : Taxidea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Taxidea taxus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Taxidea_taxus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30554;
}
