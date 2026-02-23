using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae.unclassified_Muraenesocidae;

/// <summary>
/// Abstract class for unclassified Muraenesocidae (no rank).
/// NCBI TaxId: 1189019
/// </summary>
public abstract class unclassified_Muraenesocidae : Muraenesocidae, Iunclassified_Muraenesocidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Muraenesocidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1189019;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Muraenesocidae";
}
