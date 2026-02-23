using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Astroblepidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Astroblepidae.Astroblepus;

/// <summary>
/// Abstract class for Astroblepus (genus).
/// NCBI TaxId: 245749
/// </summary>
public abstract class Astroblepus : Astroblepidae, IAstroblepus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astroblepus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245749;

    /// <inheritdoc />
    public virtual string GenusName => "Astroblepus";

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
