using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Silonia;

/// <summary>
/// Abstract class for Silonia (genus).
/// NCBI TaxId: 682368
/// </summary>
public abstract class Silonia : Schilbidae, ISilonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Silonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 682368;

    /// <inheritdoc />
    public virtual string GenusName => "Silonia";

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
