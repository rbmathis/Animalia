using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Ereuniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Ereuniidae.Marukawichthys;

/// <summary>
/// Abstract class for Marukawichthys (genus).
/// NCBI TaxId: 270553
/// </summary>
public abstract class Marukawichthys : Ereuniidae, IMarukawichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marukawichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270553;

    /// <inheritdoc />
    public virtual string GenusName => "Marukawichthys";

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
