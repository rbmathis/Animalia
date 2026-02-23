using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Canthigaster;

/// <summary>
/// Abstract class for Canthigaster (genus).
/// NCBI TaxId: 223138
/// </summary>
public abstract class Canthigaster : Tetraodontidae, ICanthigaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Canthigaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223138;

    /// <inheritdoc />
    public virtual string GenusName => "Canthigaster";

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
