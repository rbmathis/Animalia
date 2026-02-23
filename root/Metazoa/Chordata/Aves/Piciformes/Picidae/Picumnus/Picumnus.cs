using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Picumnus;

/// <summary>
/// Abstract class for Picumnus (genus).
/// NCBI TaxId: 56080
/// </summary>
public abstract class Picumnus : Picidae, IPicumnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Picumnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56080;

    /// <inheritdoc />
    public virtual string GenusName => "Picumnus";

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
