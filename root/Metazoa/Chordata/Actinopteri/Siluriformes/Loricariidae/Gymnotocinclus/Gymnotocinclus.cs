using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Gymnotocinclus;

/// <summary>
/// Abstract class for Gymnotocinclus (genus).
/// NCBI TaxId: 747057
/// </summary>
public abstract class Gymnotocinclus : Loricariidae, IGymnotocinclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnotocinclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 747057;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnotocinclus";

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
