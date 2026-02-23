using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Meliphacator;

/// <summary>
/// Abstract class for Meliphacator (genus).
/// NCBI TaxId: 3150802
/// </summary>
public abstract class Meliphacator : Meliphagidae, IMeliphacator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meliphacator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150802;

    /// <inheritdoc />
    public virtual string GenusName => "Meliphacator";

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
