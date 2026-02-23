using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Rhinotocinclus;

/// <summary>
/// Abstract class for Rhinotocinclus (genus).
/// NCBI TaxId: 3363480
/// </summary>
public abstract class Rhinotocinclus : Loricariidae, IRhinotocinclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinotocinclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363480;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinotocinclus";

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
