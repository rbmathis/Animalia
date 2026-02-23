using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Matanui;

/// <summary>
/// Abstract class for Matanui (genus).
/// NCBI TaxId: 2696665
/// </summary>
public abstract class Matanui : Tripterygiidae, IMatanui
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Matanui";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696665;

    /// <inheritdoc />
    public virtual string GenusName => "Matanui";

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
