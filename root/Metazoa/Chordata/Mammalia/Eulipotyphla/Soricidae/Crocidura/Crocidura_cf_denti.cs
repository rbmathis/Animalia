namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura cf. denti
/// NCBI TaxId: 214458
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_cf_denti : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura cf. denti";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_cf_denti";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 214458;
}
