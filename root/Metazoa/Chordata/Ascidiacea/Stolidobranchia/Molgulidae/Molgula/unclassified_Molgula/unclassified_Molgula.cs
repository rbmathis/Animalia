using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae.Molgula;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae.Molgula.unclassified_Molgula;

/// <summary>
/// Abstract class for unclassified Molgula (no rank).
/// NCBI TaxId: 2639606
/// </summary>
public abstract class unclassified_Molgula : Molgula, Iunclassified_Molgula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Molgula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639606;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Molgula";
}
