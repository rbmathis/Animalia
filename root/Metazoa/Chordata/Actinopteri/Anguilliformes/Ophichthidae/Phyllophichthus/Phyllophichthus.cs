using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Phyllophichthus;

/// <summary>
/// Abstract class for Phyllophichthus (genus).
/// NCBI TaxId: 3056087
/// </summary>
public abstract class Phyllophichthus : Ophichthidae, IPhyllophichthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllophichthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3056087;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllophichthus";

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
