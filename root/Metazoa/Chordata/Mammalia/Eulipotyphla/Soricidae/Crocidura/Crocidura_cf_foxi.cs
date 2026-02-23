namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura cf. foxi
/// NCBI TaxId: 458290
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_cf_foxi : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura cf. foxi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_cf_foxi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 458290;
}
