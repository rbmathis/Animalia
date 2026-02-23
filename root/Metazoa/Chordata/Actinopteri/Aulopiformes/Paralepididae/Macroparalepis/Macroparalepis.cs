using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Macroparalepis;

/// <summary>
/// Abstract class for Macroparalepis (genus).
/// NCBI TaxId: 509752
/// </summary>
public abstract class Macroparalepis : Paralepididae, IMacroparalepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macroparalepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 509752;

    /// <inheritdoc />
    public virtual string GenusName => "Macroparalepis";

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
