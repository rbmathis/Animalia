using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Kihnichthys;

/// <summary>
/// Abstract class for Kihnichthys (genus).
/// NCBI TaxId: 3362246
/// </summary>
public abstract class Kihnichthys : Cichlidae, IKihnichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kihnichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362246;

    /// <inheritdoc />
    public virtual string GenusName => "Kihnichthys";

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
