using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Solocisquama;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Solocisquama.unclassified_Solocisquama;

/// <summary>
/// Abstract class for unclassified Solocisquama (no rank).
/// NCBI TaxId: 2636283
/// </summary>
public abstract class unclassified_Solocisquama : Solocisquama, Iunclassified_Solocisquama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Solocisquama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636283;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Solocisquama";
}
