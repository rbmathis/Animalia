using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Argyrozona;

/// <summary>
/// Abstract class for Argyrozona (genus).
/// NCBI TaxId: 119685
/// </summary>
public abstract class Argyrozona : Sparidae, IArgyrozona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argyrozona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119685;

    /// <inheritdoc />
    public virtual string GenusName => "Argyrozona";

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
