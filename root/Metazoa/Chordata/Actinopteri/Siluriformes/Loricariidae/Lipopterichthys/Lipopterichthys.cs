using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Lipopterichthys;

/// <summary>
/// Abstract class for Lipopterichthys (genus).
/// NCBI TaxId: 1633136
/// </summary>
public abstract class Lipopterichthys : Loricariidae, ILipopterichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lipopterichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633136;

    /// <inheritdoc />
    public virtual string GenusName => "Lipopterichthys";

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
