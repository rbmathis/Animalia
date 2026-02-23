using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Muraenolepididae.Muraenolepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Muraenolepididae.Muraenolepis.unclassified_Muraenolepis;

/// <summary>
/// Abstract class for unclassified Muraenolepis (no rank).
/// NCBI TaxId: 2647270
/// </summary>
public abstract class unclassified_Muraenolepis : Muraenolepis, Iunclassified_Muraenolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Muraenolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647270;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Muraenolepis";
}
