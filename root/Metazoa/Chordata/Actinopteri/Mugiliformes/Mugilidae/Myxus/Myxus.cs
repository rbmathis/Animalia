using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Myxus;

/// <summary>
/// Abstract class for Myxus (genus).
/// NCBI TaxId: 1003961
/// </summary>
public abstract class Myxus : Mugilidae, IMyxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003961;

    /// <inheritdoc />
    public virtual string GenusName => "Myxus";

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
