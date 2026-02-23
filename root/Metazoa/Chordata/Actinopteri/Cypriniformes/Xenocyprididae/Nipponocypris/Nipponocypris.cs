using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Nipponocypris;

/// <summary>
/// Abstract class for Nipponocypris (genus).
/// NCBI TaxId: 933990
/// </summary>
public abstract class Nipponocypris : Xenocyprididae, INipponocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nipponocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 933990;

    /// <inheritdoc />
    public virtual string GenusName => "Nipponocypris";

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
