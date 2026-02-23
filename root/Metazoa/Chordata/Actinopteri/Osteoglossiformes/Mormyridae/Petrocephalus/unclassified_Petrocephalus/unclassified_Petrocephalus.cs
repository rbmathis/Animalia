using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Petrocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Petrocephalus.unclassified_Petrocephalus;

/// <summary>
/// Abstract class for unclassified Petrocephalus (no rank).
/// NCBI TaxId: 2638761
/// </summary>
public abstract class unclassified_Petrocephalus : Petrocephalus, Iunclassified_Petrocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petrocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638761;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petrocephalus";
}
