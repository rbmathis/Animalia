using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Serrasalmidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Serrasalmidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2720722
/// </summary>
public abstract class Serrasalmidae_intergeneric_hybrids : Serrasalmidae, ISerrasalmidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serrasalmidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2720722;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Serrasalmidae_intergeneric_hybrids";
}
