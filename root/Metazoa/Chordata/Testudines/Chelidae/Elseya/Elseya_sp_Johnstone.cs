namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

/// <summary>
/// Species: Elseya sp. Johnstone
/// NCBI TaxId: 321141
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elseya_sp_Johnstone : Elseya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elseya sp. Johnstone";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elseya_sp_Johnstone";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 321141;
}
