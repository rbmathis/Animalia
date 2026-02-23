using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Nimbapanchax;

/// <summary>
/// Abstract class for Nimbapanchax (genus).
/// NCBI TaxId: 696752
/// </summary>
public abstract class Nimbapanchax : Nothobranchiidae, INimbapanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nimbapanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 696752;

    /// <inheritdoc />
    public virtual string GenusName => "Nimbapanchax";

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
