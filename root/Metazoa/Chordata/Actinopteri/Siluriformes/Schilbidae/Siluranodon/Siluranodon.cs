using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Siluranodon;

/// <summary>
/// Abstract class for Siluranodon (genus).
/// NCBI TaxId: 3362509
/// </summary>
public abstract class Siluranodon : Schilbidae, ISiluranodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siluranodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362509;

    /// <inheritdoc />
    public virtual string GenusName => "Siluranodon";

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
