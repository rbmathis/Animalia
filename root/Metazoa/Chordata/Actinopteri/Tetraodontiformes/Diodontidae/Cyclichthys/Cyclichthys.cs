using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae.Cyclichthys;

/// <summary>
/// Abstract class for Cyclichthys (genus).
/// NCBI TaxId: 658181
/// </summary>
public abstract class Cyclichthys : Diodontidae, ICyclichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 658181;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclichthys";

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
