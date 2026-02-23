using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Caproiformes.Caproidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Caproiformes.Caproidae.Antigonia;

/// <summary>
/// Abstract class for Antigonia (genus).
/// NCBI TaxId: 143338
/// </summary>
public abstract class Antigonia : Caproidae, IAntigonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antigonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143338;

    /// <inheritdoc />
    public virtual string GenusName => "Antigonia";

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
