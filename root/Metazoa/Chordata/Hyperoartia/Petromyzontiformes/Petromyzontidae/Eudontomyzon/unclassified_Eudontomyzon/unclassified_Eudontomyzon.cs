using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Eudontomyzon;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Eudontomyzon.unclassified_Eudontomyzon;

/// <summary>
/// Abstract class for unclassified Eudontomyzon (no rank).
/// NCBI TaxId: 2647976
/// </summary>
public abstract class unclassified_Eudontomyzon : Eudontomyzon, Iunclassified_Eudontomyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eudontomyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647976;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eudontomyzon";
}
