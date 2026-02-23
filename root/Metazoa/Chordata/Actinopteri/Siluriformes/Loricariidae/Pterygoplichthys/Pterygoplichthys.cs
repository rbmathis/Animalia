using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pterygoplichthys;

/// <summary>
/// Abstract class for Pterygoplichthys (genus).
/// NCBI TaxId: 164016
/// </summary>
public abstract class Pterygoplichthys : Loricariidae, IPterygoplichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterygoplichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164016;

    /// <inheritdoc />
    public virtual string GenusName => "Pterygoplichthys";

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
