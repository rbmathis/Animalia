using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae.Muraenesox;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae.Muraenesox.unclassified_Muraenesox;

/// <summary>
/// Abstract class for unclassified Muraenesox (no rank).
/// NCBI TaxId: 2626115
/// </summary>
public abstract class unclassified_Muraenesox : Muraenesox, Iunclassified_Muraenesox
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Muraenesox";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626115;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Muraenesox";
}
