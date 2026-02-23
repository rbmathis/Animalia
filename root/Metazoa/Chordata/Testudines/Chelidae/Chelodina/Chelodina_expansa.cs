namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina expansa
/// NCBI TaxId: 665104
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_expansa : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina expansa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_expansa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 665104;
}
