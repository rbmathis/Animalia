namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felis;

/// <summary>
/// Species: Felis chaus x Felis catus
/// NCBI TaxId: 2576912
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Felis_chaus_x_Felis_catus : Felis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Felis chaus x Felis catus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Felis_chaus_x_Felis_catus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2576912;
}
