using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Notolabrus;

/// <summary>
/// Abstract class for Notolabrus (genus).
/// NCBI TaxId: 98381
/// </summary>
public abstract class Notolabrus : Labridae, INotolabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notolabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98381;

    /// <inheritdoc />
    public virtual string GenusName => "Notolabrus";

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
