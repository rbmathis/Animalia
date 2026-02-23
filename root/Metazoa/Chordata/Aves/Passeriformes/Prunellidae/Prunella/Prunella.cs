using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prunellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prunellidae.Prunella;

/// <summary>
/// Abstract class for Prunella (genus).
/// NCBI TaxId: 175132
/// </summary>
public abstract class Prunella : Prunellidae, IPrunella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prunella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175132;

    /// <inheritdoc />
    public virtual string GenusName => "Prunella";

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
