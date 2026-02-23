using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Paracheilinus;

/// <summary>
/// Abstract class for Paracheilinus (genus).
/// NCBI TaxId: 587060
/// </summary>
public abstract class Paracheilinus : Labridae, IParacheilinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracheilinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587060;

    /// <inheritdoc />
    public virtual string GenusName => "Paracheilinus";

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
