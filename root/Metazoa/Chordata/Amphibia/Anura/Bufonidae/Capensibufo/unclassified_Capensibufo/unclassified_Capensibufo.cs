using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Capensibufo;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Capensibufo.unclassified_Capensibufo;

/// <summary>
/// Abstract class for unclassified Capensibufo (no rank).
/// NCBI TaxId: 2617937
/// </summary>
public abstract class unclassified_Capensibufo : Capensibufo, Iunclassified_Capensibufo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Capensibufo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617937;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Capensibufo";
}
