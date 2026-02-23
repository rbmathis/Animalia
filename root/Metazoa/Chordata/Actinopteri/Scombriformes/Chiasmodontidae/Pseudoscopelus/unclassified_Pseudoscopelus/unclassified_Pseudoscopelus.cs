using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Pseudoscopelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Pseudoscopelus.unclassified_Pseudoscopelus;

/// <summary>
/// Abstract class for unclassified Pseudoscopelus (no rank).
/// NCBI TaxId: 2640458
/// </summary>
public abstract class unclassified_Pseudoscopelus : Pseudoscopelus, Iunclassified_Pseudoscopelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudoscopelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640458;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudoscopelus";
}
