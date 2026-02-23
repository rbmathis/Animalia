namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Atilax;

/// <summary>
/// Species: Atilax paludinosus
/// NCBI TaxId: 210642
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Atilax_paludinosus : Atilax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Atilax paludinosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Atilax_paludinosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 210642;
}
