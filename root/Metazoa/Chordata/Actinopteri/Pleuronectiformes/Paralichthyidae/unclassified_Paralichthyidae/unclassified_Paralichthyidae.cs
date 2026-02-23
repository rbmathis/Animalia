using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.unclassified_Paralichthyidae;

/// <summary>
/// Abstract class for unclassified Paralichthyidae (no rank).
/// NCBI TaxId: 722549
/// </summary>
public abstract class unclassified_Paralichthyidae : Paralichthyidae, Iunclassified_Paralichthyidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paralichthyidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722549;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paralichthyidae";
}
