using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Siphonogobius;

/// <summary>
/// Abstract class for Siphonogobius (genus).
/// NCBI TaxId: 3056099
/// </summary>
public abstract class Siphonogobius : Gobiidae, ISiphonogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siphonogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3056099;

    /// <inheritdoc />
    public virtual string GenusName => "Siphonogobius";

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
