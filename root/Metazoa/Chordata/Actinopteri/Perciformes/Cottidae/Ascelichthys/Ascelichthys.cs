using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Ascelichthys;

/// <summary>
/// Abstract class for Ascelichthys (genus).
/// NCBI TaxId: 1738885
/// </summary>
public abstract class Ascelichthys : Cottidae, IAscelichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ascelichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1738885;

    /// <inheritdoc />
    public virtual string GenusName => "Ascelichthys";

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
