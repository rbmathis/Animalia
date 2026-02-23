using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Spiniphryne;

/// <summary>
/// Abstract class for Spiniphryne (genus).
/// NCBI TaxId: 1738905
/// </summary>
public abstract class Spiniphryne : Oneirodidae, ISpiniphryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spiniphryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1738905;

    /// <inheritdoc />
    public virtual string GenusName => "Spiniphryne";

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
