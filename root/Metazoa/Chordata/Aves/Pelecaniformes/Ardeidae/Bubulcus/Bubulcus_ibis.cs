namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Bubulcus;

/// <summary>
/// Species: Bubulcus ibis
/// NCBI TaxId: 110668
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bubulcus_ibis : Bubulcus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bubulcus ibis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bubulcus_ibis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 110668;
}
