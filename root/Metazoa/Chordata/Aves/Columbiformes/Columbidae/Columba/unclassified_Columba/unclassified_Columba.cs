using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Columba;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Columba.unclassified_Columba;

/// <summary>
/// Abstract class for unclassified Columba (no rank).
/// NCBI TaxId: 2643597
/// </summary>
public abstract class unclassified_Columba : Columba, Iunclassified_Columba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Columba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643597;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Columba";
}
