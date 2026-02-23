using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Eliurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Eliurus.unclassified_Eliurus;

/// <summary>
/// Abstract class for unclassified Eliurus (no rank).
/// NCBI TaxId: 2641855
/// </summary>
public abstract class unclassified_Eliurus : Eliurus, Iunclassified_Eliurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eliurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641855;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eliurus";
}
