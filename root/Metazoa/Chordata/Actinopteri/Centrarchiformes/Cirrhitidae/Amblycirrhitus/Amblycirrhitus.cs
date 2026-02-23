using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Amblycirrhitus;

/// <summary>
/// Abstract class for Amblycirrhitus (genus).
/// NCBI TaxId: 390301
/// </summary>
public abstract class Amblycirrhitus : Cirrhitidae, IAmblycirrhitus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblycirrhitus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390301;

    /// <inheritdoc />
    public virtual string GenusName => "Amblycirrhitus";

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
