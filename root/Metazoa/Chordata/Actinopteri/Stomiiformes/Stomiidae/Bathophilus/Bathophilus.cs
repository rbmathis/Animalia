using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Bathophilus;

/// <summary>
/// Abstract class for Bathophilus (genus).
/// NCBI TaxId: 319448
/// </summary>
public abstract class Bathophilus : Stomiidae, IBathophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319448;

    /// <inheritdoc />
    public virtual string GenusName => "Bathophilus";

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
