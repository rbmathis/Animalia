namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Eleutherodactylus;

/// <summary>
/// Species: Eleutherodactylus johnstonei
/// NCBI TaxId: 350008
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eleutherodactylus_johnstonei : Eleutherodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eleutherodactylus johnstonei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eleutherodactylus_johnstonei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 350008;
}
