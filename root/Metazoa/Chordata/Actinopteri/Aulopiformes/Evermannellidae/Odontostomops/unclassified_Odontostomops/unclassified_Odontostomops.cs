using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae.Odontostomops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae.Odontostomops.unclassified_Odontostomops;

/// <summary>
/// Abstract class for unclassified Odontostomops (no rank).
/// NCBI TaxId: 2640404
/// </summary>
public abstract class unclassified_Odontostomops : Odontostomops, Iunclassified_Odontostomops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Odontostomops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640404;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Odontostomops";
}
