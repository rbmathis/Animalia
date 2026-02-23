using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Sporopipes;

/// <summary>
/// Abstract class for Sporopipes (genus).
/// NCBI TaxId: 187448
/// </summary>
public abstract class Sporopipes : Ploceidae, ISporopipes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sporopipes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187448;

    /// <inheritdoc />
    public virtual string GenusName => "Sporopipes";

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
