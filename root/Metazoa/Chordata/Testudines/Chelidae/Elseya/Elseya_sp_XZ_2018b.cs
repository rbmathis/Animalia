namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

/// <summary>
/// Species: Elseya sp. XZ-2018b
/// NCBI TaxId: 2080855
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elseya_sp_XZ_2018b : Elseya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elseya sp. XZ-2018b";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elseya_sp_XZ_2018b";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2080855;
}
