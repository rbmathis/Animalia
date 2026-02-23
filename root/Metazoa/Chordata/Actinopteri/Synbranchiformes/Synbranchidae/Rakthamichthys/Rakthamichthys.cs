using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Rakthamichthys;

/// <summary>
/// Abstract class for Rakthamichthys (genus).
/// NCBI TaxId: 2800821
/// </summary>
public abstract class Rakthamichthys : Synbranchidae, IRakthamichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rakthamichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2800821;

    /// <inheritdoc />
    public virtual string GenusName => "Rakthamichthys";

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
