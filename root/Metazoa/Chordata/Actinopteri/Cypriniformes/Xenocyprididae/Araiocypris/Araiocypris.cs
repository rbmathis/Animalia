using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Araiocypris;

/// <summary>
/// Abstract class for Araiocypris (genus).
/// NCBI TaxId: 3113019
/// </summary>
public abstract class Araiocypris : Xenocyprididae, IAraiocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Araiocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3113019;

    /// <inheritdoc />
    public virtual string GenusName => "Araiocypris";

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
