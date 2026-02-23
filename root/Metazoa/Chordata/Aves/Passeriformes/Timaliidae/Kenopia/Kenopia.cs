using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Kenopia;

/// <summary>
/// Abstract class for Kenopia (genus).
/// NCBI TaxId: 201344
/// </summary>
public abstract class Kenopia : Timaliidae, IKenopia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kenopia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201344;

    /// <inheritdoc />
    public virtual string GenusName => "Kenopia";

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
