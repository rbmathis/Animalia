using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Aconaemys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Aconaemys.unclassified_Aconaemys;

/// <summary>
/// Abstract class for unclassified Aconaemys (no rank).
/// NCBI TaxId: 2823131
/// </summary>
public abstract class unclassified_Aconaemys : Aconaemys, Iunclassified_Aconaemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aconaemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823131;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aconaemys";
}
