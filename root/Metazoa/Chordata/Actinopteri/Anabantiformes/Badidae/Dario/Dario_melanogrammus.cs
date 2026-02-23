namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Badidae.Dario;

/// <summary>
/// Species: Dario melanogrammus
/// NCBI TaxId: 2940085
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dario_melanogrammus : Dario
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dario melanogrammus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dario_melanogrammus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2940085;
}
