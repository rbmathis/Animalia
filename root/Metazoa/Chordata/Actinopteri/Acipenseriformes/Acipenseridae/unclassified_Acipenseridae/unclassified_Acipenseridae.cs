using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.unclassified_Acipenseridae;

/// <summary>
/// Abstract class for unclassified Acipenseridae (no rank).
/// NCBI TaxId: 136625
/// </summary>
public abstract class unclassified_Acipenseridae : Acipenseridae, Iunclassified_Acipenseridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acipenseridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 136625;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acipenseridae";
}
