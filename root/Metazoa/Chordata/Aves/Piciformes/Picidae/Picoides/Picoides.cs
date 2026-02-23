using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Picoides;

/// <summary>
/// Abstract class for Picoides (genus).
/// NCBI TaxId: 36302
/// </summary>
public abstract class Picoides : Picidae, IPicoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Picoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36302;

    /// <inheritdoc />
    public virtual string GenusName => "Picoides";

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
