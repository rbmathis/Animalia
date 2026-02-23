using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae.Microparra;

/// <summary>
/// Abstract class for Microparra (genus).
/// NCBI TaxId: 118789
/// </summary>
public abstract class Microparra : Jacanidae, IMicroparra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microparra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118789;

    /// <inheritdoc />
    public virtual string GenusName => "Microparra";

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
