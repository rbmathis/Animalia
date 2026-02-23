namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

/// <summary>
/// Species: Elseya sp. XZ-2018a
/// NCBI TaxId: 2080853
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elseya_sp_XZ_2018a : Elseya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elseya sp. XZ-2018a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elseya_sp_XZ_2018a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2080853;
}
