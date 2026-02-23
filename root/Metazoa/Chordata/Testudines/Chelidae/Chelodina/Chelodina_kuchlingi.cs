namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina kuchlingi
/// NCBI TaxId: 3146100
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_kuchlingi : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina kuchlingi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_kuchlingi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3146100;
}
