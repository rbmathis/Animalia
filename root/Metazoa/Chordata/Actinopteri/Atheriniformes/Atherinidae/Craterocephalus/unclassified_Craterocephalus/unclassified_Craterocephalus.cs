using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Craterocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Craterocephalus.unclassified_Craterocephalus;

/// <summary>
/// Abstract class for unclassified Craterocephalus (no rank).
/// NCBI TaxId: 2630387
/// </summary>
public abstract class unclassified_Craterocephalus : Craterocephalus, Iunclassified_Craterocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Craterocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630387;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Craterocephalus";
}
