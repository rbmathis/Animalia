using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Schizopygopsis;

/// <summary>
/// Abstract class for Schizopygopsis (genus).
/// NCBI TaxId: 263520
/// </summary>
public abstract class Schizopygopsis : Cyprinidae, ISchizopygopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schizopygopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 263520;

    /// <inheritdoc />
    public virtual string GenusName => "Schizopygopsis";

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
