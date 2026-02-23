using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Physiculus;

/// <summary>
/// Abstract class for Physiculus (genus).
/// NCBI TaxId: 181407
/// </summary>
public abstract class Physiculus : Moridae, IPhysiculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Physiculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181407;

    /// <inheritdoc />
    public virtual string GenusName => "Physiculus";

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
