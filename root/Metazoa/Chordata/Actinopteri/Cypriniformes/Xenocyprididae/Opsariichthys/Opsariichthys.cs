using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Opsariichthys;

/// <summary>
/// Abstract class for Opsariichthys (genus).
/// NCBI TaxId: 39567
/// </summary>
public abstract class Opsariichthys : Xenocyprididae, IOpsariichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opsariichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39567;

    /// <inheritdoc />
    public virtual string GenusName => "Opsariichthys";

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
