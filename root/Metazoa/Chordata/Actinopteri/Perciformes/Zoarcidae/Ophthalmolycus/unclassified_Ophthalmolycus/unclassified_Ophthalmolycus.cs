using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Ophthalmolycus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Ophthalmolycus.unclassified_Ophthalmolycus;

/// <summary>
/// Abstract class for unclassified Ophthalmolycus (no rank).
/// NCBI TaxId: 2628578
/// </summary>
public abstract class unclassified_Ophthalmolycus : Ophthalmolycus, Iunclassified_Ophthalmolycus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophthalmolycus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628578;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophthalmolycus";
}
