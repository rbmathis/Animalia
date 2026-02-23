using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Acyrtus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Acyrtus.unclassified_Acyrtus;

/// <summary>
/// Abstract class for unclassified Acyrtus (no rank).
/// NCBI TaxId: 2643586
/// </summary>
public abstract class unclassified_Acyrtus : Acyrtus, Iunclassified_Acyrtus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acyrtus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643586;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acyrtus";
}
