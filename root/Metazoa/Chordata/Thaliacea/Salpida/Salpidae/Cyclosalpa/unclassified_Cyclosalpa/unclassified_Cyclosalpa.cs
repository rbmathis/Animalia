using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Cyclosalpa;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Cyclosalpa.unclassified_Cyclosalpa;

/// <summary>
/// Abstract class for unclassified Cyclosalpa (no rank).
/// NCBI TaxId: 2783195
/// </summary>
public abstract class unclassified_Cyclosalpa : Cyclosalpa, Iunclassified_Cyclosalpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyclosalpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2783195;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyclosalpa";
}
