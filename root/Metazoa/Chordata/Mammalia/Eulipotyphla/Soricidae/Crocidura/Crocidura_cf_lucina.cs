namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura cf. lucina
/// NCBI TaxId: 561557
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_cf_lucina : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura cf. lucina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_cf_lucina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 561557;
}
