using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudotocinclus;

/// <summary>
/// Abstract class for Pseudotocinclus (genus).
/// NCBI TaxId: 321130
/// </summary>
public abstract class Pseudotocinclus : Loricariidae, IPseudotocinclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudotocinclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321130;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudotocinclus";

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
