using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.unclassified_Holocephali;

/// <summary>
/// Abstract class for unclassified Holocephali (no rank).
/// NCBI TaxId: 1414506
/// </summary>
public abstract class unclassified_Holocephali : Chondrichthyes, Iunclassified_Holocephali
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Holocephali";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1414506;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Holocephali";
}
