using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Myleus;

/// <summary>
/// Abstract class for Myleus (genus).
/// NCBI TaxId: 42545
/// </summary>
public abstract class Myleus : Serrasalmidae, IMyleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myleus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42545;

    /// <inheritdoc />
    public virtual string GenusName => "Myleus";

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
