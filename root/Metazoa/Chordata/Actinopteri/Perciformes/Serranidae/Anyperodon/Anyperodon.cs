using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Anyperodon;

/// <summary>
/// Abstract class for Anyperodon (genus).
/// NCBI TaxId: 160701
/// </summary>
public abstract class Anyperodon : Serranidae, IAnyperodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anyperodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 160701;

    /// <inheritdoc />
    public virtual string GenusName => "Anyperodon";

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
