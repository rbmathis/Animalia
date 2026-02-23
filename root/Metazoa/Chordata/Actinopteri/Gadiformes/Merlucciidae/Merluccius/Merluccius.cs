using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Merluccius;

/// <summary>
/// Abstract class for Merluccius (genus).
/// NCBI TaxId: 8062
/// </summary>
public abstract class Merluccius : Merlucciidae, IMerluccius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Merluccius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8062;

    /// <inheritdoc />
    public virtual string GenusName => "Merluccius";

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
