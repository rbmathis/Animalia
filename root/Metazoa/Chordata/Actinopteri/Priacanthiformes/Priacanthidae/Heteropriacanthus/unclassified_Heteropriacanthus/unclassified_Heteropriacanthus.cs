using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae.Heteropriacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae.Heteropriacanthus.unclassified_Heteropriacanthus;

/// <summary>
/// Abstract class for unclassified Heteropriacanthus (no rank).
/// NCBI TaxId: 2630723
/// </summary>
public abstract class unclassified_Heteropriacanthus : Heteropriacanthus, Iunclassified_Heteropriacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heteropriacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630723;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heteropriacanthus";
}
