namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Allenopithecus;

/// <summary>
/// Species: Allenopithecus nigroviridis
/// NCBI TaxId: 54135
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Allenopithecus_nigroviridis : Allenopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Allenopithecus nigroviridis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Allenopithecus_nigroviridis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 54135;
}
