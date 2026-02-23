namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura sp. SSD-2006
/// NCBI TaxId: 389267
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_sp_SSD_2006 : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura sp. SSD-2006";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_sp_SSD_2006";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 389267;
}
