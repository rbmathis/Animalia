namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

/// <summary>
/// Species: Elseya sp.
/// NCBI TaxId: 2563987
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elseya_sp : Elseya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elseya sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elseya_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2563987;
}
