using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Cottapistus;

/// <summary>
/// Abstract class for Cottapistus (genus).
/// NCBI TaxId: 1604638
/// </summary>
public abstract class Cottapistus : Tetrarogidae, ICottapistus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cottapistus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1604638;

    /// <inheritdoc />
    public virtual string GenusName => "Cottapistus";

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
