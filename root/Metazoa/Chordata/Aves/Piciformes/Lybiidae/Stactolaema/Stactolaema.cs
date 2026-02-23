using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Stactolaema;

/// <summary>
/// Abstract class for Stactolaema (genus).
/// NCBI TaxId: 135182
/// </summary>
public abstract class Stactolaema : Lybiidae, IStactolaema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stactolaema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135182;

    /// <inheritdoc />
    public virtual string GenusName => "Stactolaema";

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
