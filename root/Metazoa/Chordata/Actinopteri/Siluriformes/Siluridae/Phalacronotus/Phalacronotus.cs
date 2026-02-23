using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Phalacronotus;

/// <summary>
/// Abstract class for Phalacronotus (genus).
/// NCBI TaxId: 709447
/// </summary>
public abstract class Phalacronotus : Siluridae, IPhalacronotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phalacronotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 709447;

    /// <inheritdoc />
    public virtual string GenusName => "Phalacronotus";

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
