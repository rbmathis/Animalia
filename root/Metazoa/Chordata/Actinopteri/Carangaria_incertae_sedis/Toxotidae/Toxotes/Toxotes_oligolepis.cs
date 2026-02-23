namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Toxotidae.Toxotes;

/// <summary>
/// Species: Toxotes oligolepis
/// NCBI TaxId: 1853211
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Toxotes_oligolepis : Toxotes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Toxotes oligolepis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Toxotes_oligolepis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1853211;
}
