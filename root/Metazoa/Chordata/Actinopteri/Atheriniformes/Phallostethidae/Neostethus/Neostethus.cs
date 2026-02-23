using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Phallostethidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Phallostethidae.Neostethus;

/// <summary>
/// Abstract class for Neostethus (genus).
/// NCBI TaxId: 300305
/// </summary>
public abstract class Neostethus : Phallostethidae, INeostethus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neostethus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 300305;

    /// <inheritdoc />
    public virtual string GenusName => "Neostethus";

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
