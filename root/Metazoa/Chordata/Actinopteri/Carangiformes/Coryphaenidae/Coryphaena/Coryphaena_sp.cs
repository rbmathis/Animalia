namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Coryphaenidae.Coryphaena;

/// <summary>
/// Species: Coryphaena sp.
/// NCBI TaxId: 3122146
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coryphaena_sp : Coryphaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coryphaena sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coryphaena_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3122146;
}
