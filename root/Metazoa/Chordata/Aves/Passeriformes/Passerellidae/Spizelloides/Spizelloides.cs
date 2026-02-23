using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Spizelloides;

/// <summary>
/// Abstract class for Spizelloides (genus).
/// NCBI TaxId: 2651852
/// </summary>
public abstract class Spizelloides : Passerellidae, ISpizelloides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spizelloides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2651852;

    /// <inheritdoc />
    public virtual string GenusName => "Spizelloides";

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
