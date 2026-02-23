using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Urolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Urolophidae.Urolophus;

/// <summary>
/// Abstract class for Urolophus (genus).
/// NCBI TaxId: 40663
/// </summary>
public abstract class Urolophus : Urolophidae, IUrolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40663;

    /// <inheritdoc />
    public virtual string GenusName => "Urolophus";

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
