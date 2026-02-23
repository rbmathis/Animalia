namespace AnimalKingdom.root.Metazoa.Chordata.unclassified_Vertebrata_in_vertebrates;

/// <summary>
/// Species: Vertebrata sp. (in: vertebrates)
/// NCBI TaxId: 3100109
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vertebrata_sp_in_vertebrates : unclassified_Vertebrata_in_vertebrates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vertebrata sp. (in: vertebrates)";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vertebrata_sp_in_vertebrates";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3100109;
}
