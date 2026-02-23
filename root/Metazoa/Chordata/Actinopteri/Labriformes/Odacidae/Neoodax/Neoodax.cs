using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae.Neoodax;

/// <summary>
/// Abstract class for Neoodax (genus).
/// NCBI TaxId: 241358
/// </summary>
public abstract class Neoodax : Odacidae, INeoodax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoodax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241358;

    /// <inheritdoc />
    public virtual string GenusName => "Neoodax";

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
