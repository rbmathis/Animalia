using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Notharchus;

/// <summary>
/// Abstract class for Notharchus (genus).
/// NCBI TaxId: 592657
/// </summary>
public abstract class Notharchus : Bucconidae, INotharchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notharchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 592657;

    /// <inheritdoc />
    public virtual string GenusName => "Notharchus";

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
