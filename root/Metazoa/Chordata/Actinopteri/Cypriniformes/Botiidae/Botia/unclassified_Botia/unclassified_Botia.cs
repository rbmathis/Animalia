using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Botia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Botia.unclassified_Botia;

/// <summary>
/// Abstract class for unclassified Botia (no rank).
/// NCBI TaxId: 2646006
/// </summary>
public abstract class unclassified_Botia : Botia, Iunclassified_Botia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Botia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646006;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Botia";
}
