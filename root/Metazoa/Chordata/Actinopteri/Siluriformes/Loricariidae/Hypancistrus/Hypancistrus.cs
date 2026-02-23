using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hypancistrus;

/// <summary>
/// Abstract class for Hypancistrus (genus).
/// NCBI TaxId: 281747
/// </summary>
public abstract class Hypancistrus : Loricariidae, IHypancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 281747;

    /// <inheritdoc />
    public virtual string GenusName => "Hypancistrus";

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
