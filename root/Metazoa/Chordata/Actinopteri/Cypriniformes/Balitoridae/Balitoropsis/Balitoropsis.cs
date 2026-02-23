using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Balitoropsis;

/// <summary>
/// Abstract class for Balitoropsis (genus).
/// NCBI TaxId: 1590161
/// </summary>
public abstract class Balitoropsis : Balitoridae, IBalitoropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balitoropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1590161;

    /// <inheritdoc />
    public virtual string GenusName => "Balitoropsis";

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
