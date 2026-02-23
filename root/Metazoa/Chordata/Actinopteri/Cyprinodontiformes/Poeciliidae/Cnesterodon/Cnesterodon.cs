using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Cnesterodon;

/// <summary>
/// Abstract class for Cnesterodon (genus).
/// NCBI TaxId: 28749
/// </summary>
public abstract class Cnesterodon : Poeciliidae, ICnesterodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cnesterodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28749;

    /// <inheritdoc />
    public virtual string GenusName => "Cnesterodon";

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
