using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Hemibates;

/// <summary>
/// Abstract class for Hemibates (genus).
/// NCBI TaxId: 286577
/// </summary>
public abstract class Hemibates : Cichlidae, IHemibates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemibates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286577;

    /// <inheritdoc />
    public virtual string GenusName => "Hemibates";

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
