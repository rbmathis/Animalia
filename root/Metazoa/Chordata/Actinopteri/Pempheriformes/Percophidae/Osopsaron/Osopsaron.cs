using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Osopsaron;

/// <summary>
/// Abstract class for Osopsaron (genus).
/// NCBI TaxId: 1633523
/// </summary>
public abstract class Osopsaron : Percophidae, IOsopsaron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osopsaron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633523;

    /// <inheritdoc />
    public virtual string GenusName => "Osopsaron";

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
