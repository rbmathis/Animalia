using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Itycirrhitus;

/// <summary>
/// Abstract class for Itycirrhitus (genus).
/// NCBI TaxId: 1278957
/// </summary>
public abstract class Itycirrhitus : Cirrhitidae, IItycirrhitus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Itycirrhitus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1278957;

    /// <inheritdoc />
    public virtual string GenusName => "Itycirrhitus";

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
