using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Leptonotus;

/// <summary>
/// Abstract class for Leptonotus (genus).
/// NCBI TaxId: 1095085
/// </summary>
public abstract class Leptonotus : Syngnathidae, ILeptonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1095085;

    /// <inheritdoc />
    public virtual string GenusName => "Leptonotus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
