using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prionopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prionopidae.Tephrodornis;

/// <summary>
/// Abstract class for Tephrodornis (genus).
/// NCBI TaxId: 316101
/// </summary>
public abstract class Tephrodornis : Prionopidae, ITephrodornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tephrodornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316101;

    /// <inheritdoc />
    public virtual string GenusName => "Tephrodornis";

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
