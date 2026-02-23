using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Kronichthys;

/// <summary>
/// Abstract class for Kronichthys (genus).
/// NCBI TaxId: 510819
/// </summary>
public abstract class Kronichthys : Loricariidae, IKronichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kronichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 510819;

    /// <inheritdoc />
    public virtual string GenusName => "Kronichthys";

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
