using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae.Odax;

/// <summary>
/// Abstract class for Odax (genus).
/// NCBI TaxId: 241360
/// </summary>
public abstract class Odax : Odacidae, IOdax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241360;

    /// <inheritdoc />
    public virtual string GenusName => "Odax";

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
