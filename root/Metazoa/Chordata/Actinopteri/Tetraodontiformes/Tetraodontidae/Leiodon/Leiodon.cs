using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Leiodon;

/// <summary>
/// Abstract class for Leiodon (genus).
/// NCBI TaxId: 1504153
/// </summary>
public abstract class Leiodon : Tetraodontidae, ILeiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1504153;

    /// <inheritdoc />
    public virtual string GenusName => "Leiodon";

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
