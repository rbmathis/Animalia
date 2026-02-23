using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Mirorictus;

/// <summary>
/// Abstract class for Mirorictus (genus).
/// NCBI TaxId: 740929
/// </summary>
public abstract class Mirorictus : Platytroctidae, IMirorictus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mirorictus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 740929;

    /// <inheritdoc />
    public virtual string GenusName => "Mirorictus";

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
