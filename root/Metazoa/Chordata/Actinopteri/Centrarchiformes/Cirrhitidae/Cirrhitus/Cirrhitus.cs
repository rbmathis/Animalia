using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Cirrhitus;

/// <summary>
/// Abstract class for Cirrhitus (genus).
/// NCBI TaxId: 76915
/// </summary>
public abstract class Cirrhitus : Cirrhitidae, ICirrhitus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cirrhitus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76915;

    /// <inheritdoc />
    public virtual string GenusName => "Cirrhitus";

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
