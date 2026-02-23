using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Blythipicus;

/// <summary>
/// Abstract class for Blythipicus (genus).
/// NCBI TaxId: 301991
/// </summary>
public abstract class Blythipicus : Picidae, IBlythipicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blythipicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 301991;

    /// <inheritdoc />
    public virtual string GenusName => "Blythipicus";

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
