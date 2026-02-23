using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Tremarctos;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Tremarctos.unclassified_Tremarctos;

/// <summary>
/// Abstract class for unclassified Tremarctos (no rank).
/// NCBI TaxId: 2632987
/// </summary>
public abstract class unclassified_Tremarctos : Tremarctos, Iunclassified_Tremarctos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tremarctos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632987;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tremarctos";
}
