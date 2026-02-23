namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Tytonidae.Tyto;

/// <summary>
/// Species: Tyto glaucops
/// NCBI TaxId: 126849
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tyto_glaucops : Tyto
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tyto glaucops";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tyto_glaucops";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 126849;
}
