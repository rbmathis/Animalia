using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Choeroichthys;

/// <summary>
/// Abstract class for Choeroichthys (genus).
/// NCBI TaxId: 1156466
/// </summary>
public abstract class Choeroichthys : Syngnathidae, IChoeroichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Choeroichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156466;

    /// <inheritdoc />
    public virtual string GenusName => "Choeroichthys";

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
