namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Cacatua;

/// <summary>
/// Species: Cacatua ophthalmica
/// NCBI TaxId: 141835
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cacatua_ophthalmica : Cacatua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cacatua ophthalmica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cacatua_ophthalmica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 141835;
}
