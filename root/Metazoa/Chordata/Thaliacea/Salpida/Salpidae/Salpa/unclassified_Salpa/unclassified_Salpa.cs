using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Salpa;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Salpa.unclassified_Salpa;

/// <summary>
/// Abstract class for unclassified Salpa (no rank).
/// NCBI TaxId: 2625013
/// </summary>
public abstract class unclassified_Salpa : Salpa, Iunclassified_Salpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625013;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salpa";
}
