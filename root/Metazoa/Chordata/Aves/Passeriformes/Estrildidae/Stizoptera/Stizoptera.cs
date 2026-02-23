using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Stizoptera;

/// <summary>
/// Abstract class for Stizoptera (genus).
/// NCBI TaxId: 2823315
/// </summary>
public abstract class Stizoptera : Estrildidae, IStizoptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stizoptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823315;

    /// <inheritdoc />
    public virtual string GenusName => "Stizoptera";

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
