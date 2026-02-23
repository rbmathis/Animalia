using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Deltentosteus;

/// <summary>
/// Abstract class for Deltentosteus (genus).
/// NCBI TaxId: 159851
/// </summary>
public abstract class Deltentosteus : Gobiidae, IDeltentosteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deltentosteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 159851;

    /// <inheritdoc />
    public virtual string GenusName => "Deltentosteus";

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
