using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Chanodichthys;

/// <summary>
/// Abstract class for Chanodichthys (genus).
/// NCBI TaxId: 291793
/// </summary>
public abstract class Chanodichthys : Xenocyprididae, IChanodichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chanodichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 291793;

    /// <inheritdoc />
    public virtual string GenusName => "Chanodichthys";

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
