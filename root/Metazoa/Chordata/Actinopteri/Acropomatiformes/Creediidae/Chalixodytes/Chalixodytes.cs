using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Chalixodytes;

/// <summary>
/// Abstract class for Chalixodytes (genus).
/// NCBI TaxId: 1156464
/// </summary>
public abstract class Chalixodytes : Creediidae, IChalixodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalixodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156464;

    /// <inheritdoc />
    public virtual string GenusName => "Chalixodytes";

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
