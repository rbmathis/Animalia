using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Lullula;

/// <summary>
/// Abstract class for Lullula (genus).
/// NCBI TaxId: 215314
/// </summary>
public abstract class Lullula : Alaudidae, ILullula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lullula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215314;

    /// <inheritdoc />
    public virtual string GenusName => "Lullula";

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
