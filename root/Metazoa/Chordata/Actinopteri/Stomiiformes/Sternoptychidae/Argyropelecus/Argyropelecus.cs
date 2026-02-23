using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Argyropelecus;

/// <summary>
/// Abstract class for Argyropelecus (genus).
/// NCBI TaxId: 68503
/// </summary>
public abstract class Argyropelecus : Sternoptychidae, IArgyropelecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argyropelecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68503;

    /// <inheritdoc />
    public virtual string GenusName => "Argyropelecus";

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
