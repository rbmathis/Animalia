using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus.unclassified_Mus_in_rodents;

/// <summary>
/// Abstract class for unclassified Mus (in: rodents) (no rank).
/// NCBI TaxId: 3407018
/// </summary>
public abstract class unclassified_Mus_in_rodents : Mus, Iunclassified_Mus_in_rodents
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mus (in: rodents)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3407018;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mus_in_rodents";
}
