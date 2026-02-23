using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae.Acropoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae.Acropoma.unclassified_Acropoma;

/// <summary>
/// Abstract class for unclassified Acropoma (no rank).
/// NCBI TaxId: 2641887
/// </summary>
public abstract class unclassified_Acropoma : Acropoma, Iunclassified_Acropoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acropoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641887;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acropoma";
}
