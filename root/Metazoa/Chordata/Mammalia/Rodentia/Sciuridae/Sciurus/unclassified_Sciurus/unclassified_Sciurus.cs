using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurus.unclassified_Sciurus;

/// <summary>
/// Abstract class for unclassified Sciurus (no rank).
/// NCBI TaxId: 2636427
/// </summary>
public abstract class unclassified_Sciurus : Sciurus, Iunclassified_Sciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636427;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sciurus";
}
