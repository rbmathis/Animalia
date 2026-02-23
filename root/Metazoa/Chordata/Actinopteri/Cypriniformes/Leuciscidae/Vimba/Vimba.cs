using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Vimba;

/// <summary>
/// Abstract class for Vimba (genus).
/// NCBI TaxId: 101898
/// </summary>
public abstract class Vimba : Leuciscidae, IVimba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vimba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101898;

    /// <inheritdoc />
    public virtual string GenusName => "Vimba";

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
