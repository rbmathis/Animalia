using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Lampanyctus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Lampanyctus.unclassified_Lampanyctus;

/// <summary>
/// Abstract class for unclassified Lampanyctus (no rank).
/// NCBI TaxId: 2622588
/// </summary>
public abstract class unclassified_Lampanyctus : Lampanyctus, Iunclassified_Lampanyctus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lampanyctus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622588;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lampanyctus";
}
