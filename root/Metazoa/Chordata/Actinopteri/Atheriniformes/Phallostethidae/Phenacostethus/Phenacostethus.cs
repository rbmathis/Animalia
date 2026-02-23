using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Phallostethidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Phallostethidae.Phenacostethus;

/// <summary>
/// Abstract class for Phenacostethus (genus).
/// NCBI TaxId: 270657
/// </summary>
public abstract class Phenacostethus : Phallostethidae, IPhenacostethus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phenacostethus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270657;

    /// <inheritdoc />
    public virtual string GenusName => "Phenacostethus";

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
