using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Astronesthes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Astronesthes.unclassified_Astronesthes;

/// <summary>
/// Abstract class for unclassified Astronesthes (no rank).
/// NCBI TaxId: 2626806
/// </summary>
public abstract class unclassified_Astronesthes : Astronesthes, Iunclassified_Astronesthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Astronesthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626806;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Astronesthes";
}
