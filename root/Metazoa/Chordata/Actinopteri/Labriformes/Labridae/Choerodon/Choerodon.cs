using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Choerodon;

/// <summary>
/// Abstract class for Choerodon (genus).
/// NCBI TaxId: 91744
/// </summary>
public abstract class Choerodon : Labridae, IChoerodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Choerodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91744;

    /// <inheritdoc />
    public virtual string GenusName => "Choerodon";

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
