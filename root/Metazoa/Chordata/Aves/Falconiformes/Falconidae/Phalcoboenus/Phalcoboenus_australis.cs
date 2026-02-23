namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Phalcoboenus;

/// <summary>
/// Species: Phalcoboenus australis
/// NCBI TaxId: 56345
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phalcoboenus_australis : Phalcoboenus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phalcoboenus australis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phalcoboenus_australis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56345;
}
