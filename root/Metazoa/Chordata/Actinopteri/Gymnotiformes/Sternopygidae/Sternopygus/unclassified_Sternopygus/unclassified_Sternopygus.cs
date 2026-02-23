using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Sternopygus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Sternopygus.unclassified_Sternopygus;

/// <summary>
/// Abstract class for unclassified Sternopygus (no rank).
/// NCBI TaxId: 2647424
/// </summary>
public abstract class unclassified_Sternopygus : Sternopygus, Iunclassified_Sternopygus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sternopygus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647424;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sternopygus";
}
