using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Isocirrhitus;

/// <summary>
/// Abstract class for Isocirrhitus (genus).
/// NCBI TaxId: 2589343
/// </summary>
public abstract class Isocirrhitus : Cirrhitidae, IIsocirrhitus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isocirrhitus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2589343;

    /// <inheritdoc />
    public virtual string GenusName => "Isocirrhitus";

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
