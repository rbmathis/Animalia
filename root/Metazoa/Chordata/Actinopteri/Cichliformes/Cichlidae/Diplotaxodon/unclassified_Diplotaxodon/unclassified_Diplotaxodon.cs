using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Diplotaxodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Diplotaxodon.unclassified_Diplotaxodon;

/// <summary>
/// Abstract class for unclassified Diplotaxodon (no rank).
/// NCBI TaxId: 2609045
/// </summary>
public abstract class unclassified_Diplotaxodon : Diplotaxodon, Iunclassified_Diplotaxodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diplotaxodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609045;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diplotaxodon";
}
