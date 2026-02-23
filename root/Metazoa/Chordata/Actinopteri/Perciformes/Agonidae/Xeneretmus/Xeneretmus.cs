using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Xeneretmus;

/// <summary>
/// Abstract class for Xeneretmus (genus).
/// NCBI TaxId: 274779
/// </summary>
public abstract class Xeneretmus : Agonidae, IXeneretmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xeneretmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274779;

    /// <inheritdoc />
    public virtual string GenusName => "Xeneretmus";

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
