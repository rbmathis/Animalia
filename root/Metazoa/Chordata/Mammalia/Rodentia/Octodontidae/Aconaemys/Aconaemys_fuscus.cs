namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Aconaemys;

/// <summary>
/// Species: Aconaemys fuscus
/// NCBI TaxId: 183514
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aconaemys_fuscus : Aconaemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aconaemys fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aconaemys_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 183514;
}
