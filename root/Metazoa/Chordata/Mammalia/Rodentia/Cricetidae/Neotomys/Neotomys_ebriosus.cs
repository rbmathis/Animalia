namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neotomys;

/// <summary>
/// Species: Neotomys ebriosus
/// NCBI TaxId: 1007658
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neotomys_ebriosus : Neotomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neotomys ebriosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neotomys_ebriosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1007658;
}
