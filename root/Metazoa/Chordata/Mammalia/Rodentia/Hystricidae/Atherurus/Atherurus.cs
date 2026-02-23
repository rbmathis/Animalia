using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae.Atherurus;

/// <summary>
/// Abstract class for Atherurus (genus).
/// NCBI TaxId: 34835
/// </summary>
public abstract class Atherurus : Hystricidae, IAtherurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atherurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34835;

    /// <inheritdoc />
    public virtual string GenusName => "Atherurus";

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
