using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gnathopogon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gnathopogon.unclassified_Gnathopogon;

/// <summary>
/// Abstract class for unclassified Gnathopogon (no rank).
/// NCBI TaxId: 2742480
/// </summary>
public abstract class unclassified_Gnathopogon : Gnathopogon, Iunclassified_Gnathopogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gnathopogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2742480;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gnathopogon";
}
