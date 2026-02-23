using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Dermophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Dermophiidae.Dermophis;

/// <summary>
/// Abstract class for Dermophis (genus).
/// NCBI TaxId: 118250
/// </summary>
public abstract class Dermophis : Dermophiidae, IDermophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dermophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118250;

    /// <inheritdoc />
    public virtual string GenusName => "Dermophis";

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
