using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.unclassified_Cercosaurinae;

/// <summary>
/// Abstract class for unclassified Cercosaurinae (no rank).
/// NCBI TaxId: 2293925
/// </summary>
public abstract class unclassified_Cercosaurinae : Gymnophthalmidae, Iunclassified_Cercosaurinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cercosaurinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2293925;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cercosaurinae";
}
