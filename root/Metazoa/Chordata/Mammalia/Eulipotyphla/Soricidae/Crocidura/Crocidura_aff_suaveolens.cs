namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

/// <summary>
/// Species: Crocidura aff. suaveolens
/// NCBI TaxId: 1868626
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocidura_aff_suaveolens : Crocidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocidura aff. suaveolens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocidura_aff_suaveolens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1868626;
}
