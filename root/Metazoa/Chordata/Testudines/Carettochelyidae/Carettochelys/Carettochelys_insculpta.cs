namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Carettochelyidae.Carettochelys;

/// <summary>
/// Species: Carettochelys insculpta
/// NCBI TaxId: 44489
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carettochelys_insculpta : Carettochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carettochelys insculpta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carettochelys_insculpta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44489;
}
