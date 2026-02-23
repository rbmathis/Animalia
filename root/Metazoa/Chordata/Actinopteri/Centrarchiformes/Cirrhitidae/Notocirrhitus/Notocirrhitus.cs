using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Notocirrhitus;

/// <summary>
/// Abstract class for Notocirrhitus (genus).
/// NCBI TaxId: 490290
/// </summary>
public abstract class Notocirrhitus : Cirrhitidae, INotocirrhitus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notocirrhitus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490290;

    /// <inheritdoc />
    public virtual string GenusName => "Notocirrhitus";

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
