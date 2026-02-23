using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Oplegnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Oplegnathidae.Oplegnathus;

/// <summary>
/// Abstract class for Oplegnathus (genus).
/// NCBI TaxId: 163133
/// </summary>
public abstract class Oplegnathus : Oplegnathidae, IOplegnathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oplegnathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163133;

    /// <inheritdoc />
    public virtual string GenusName => "Oplegnathus";

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
