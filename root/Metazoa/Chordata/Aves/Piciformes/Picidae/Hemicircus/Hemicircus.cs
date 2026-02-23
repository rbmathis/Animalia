using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Hemicircus;

/// <summary>
/// Abstract class for Hemicircus (genus).
/// NCBI TaxId: 367972
/// </summary>
public abstract class Hemicircus : Picidae, IHemicircus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemicircus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 367972;

    /// <inheritdoc />
    public virtual string GenusName => "Hemicircus";

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
