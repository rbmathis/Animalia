using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Otocinclus;

/// <summary>
/// Abstract class for Otocinclus (genus).
/// NCBI TaxId: 281757
/// </summary>
public abstract class Otocinclus : Loricariidae, IOtocinclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otocinclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 281757;

    /// <inheritdoc />
    public virtual string GenusName => "Otocinclus";

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
