using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cirrhinus;

/// <summary>
/// Abstract class for Cirrhinus (genus).
/// NCBI TaxId: 59897
/// </summary>
public abstract class Cirrhinus : Cyprinidae, ICirrhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cirrhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59897;

    /// <inheritdoc />
    public virtual string GenusName => "Cirrhinus";

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
