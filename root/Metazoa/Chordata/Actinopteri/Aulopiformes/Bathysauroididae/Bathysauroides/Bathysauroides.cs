using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauroididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauroididae.Bathysauroides;

/// <summary>
/// Abstract class for Bathysauroides (genus).
/// NCBI TaxId: 1489834
/// </summary>
public abstract class Bathysauroides : Bathysauroididae, IBathysauroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathysauroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1489834;

    /// <inheritdoc />
    public virtual string GenusName => "Bathysauroides";

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
