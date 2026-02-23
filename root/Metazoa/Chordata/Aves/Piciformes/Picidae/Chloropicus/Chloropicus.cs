using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Chloropicus;

/// <summary>
/// Abstract class for Chloropicus (genus).
/// NCBI TaxId: 1638933
/// </summary>
public abstract class Chloropicus : Picidae, IChloropicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chloropicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1638933;

    /// <inheritdoc />
    public virtual string GenusName => "Chloropicus";

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
