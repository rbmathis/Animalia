using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Isonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Isonidae.Iso;

/// <summary>
/// Abstract class for Iso (genus).
/// NCBI TaxId: 238707
/// </summary>
public abstract class Iso : Isonidae, IIso
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iso";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238707;

    /// <inheritdoc />
    public virtual string GenusName => "Iso";

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
