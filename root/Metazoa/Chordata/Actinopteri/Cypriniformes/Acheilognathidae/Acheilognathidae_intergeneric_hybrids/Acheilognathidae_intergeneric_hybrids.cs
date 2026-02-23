using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Acheilognathidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Acheilognathidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2871507
/// </summary>
public abstract class Acheilognathidae_intergeneric_hybrids : Acheilognathidae, IAcheilognathidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acheilognathidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2871507;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Acheilognathidae_intergeneric_hybrids";
}
