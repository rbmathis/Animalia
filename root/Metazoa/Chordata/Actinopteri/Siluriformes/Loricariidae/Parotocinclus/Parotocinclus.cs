using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Parotocinclus;

/// <summary>
/// Abstract class for Parotocinclus (genus).
/// NCBI TaxId: 281768
/// </summary>
public abstract class Parotocinclus : Loricariidae, IParotocinclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parotocinclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 281768;

    /// <inheritdoc />
    public virtual string GenusName => "Parotocinclus";

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
