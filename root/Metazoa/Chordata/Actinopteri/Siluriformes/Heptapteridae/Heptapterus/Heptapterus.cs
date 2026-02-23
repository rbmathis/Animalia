using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Heptapterus;

/// <summary>
/// Abstract class for Heptapterus (genus).
/// NCBI TaxId: 162151
/// </summary>
public abstract class Heptapterus : Heptapteridae, IHeptapterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heptapterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 162151;

    /// <inheritdoc />
    public virtual string GenusName => "Heptapterus";

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
