using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Picathartidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Picathartidae.Picathartes;

/// <summary>
/// Abstract class for Picathartes (genus).
/// NCBI TaxId: 175130
/// </summary>
public abstract class Picathartes : Picathartidae, IPicathartes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Picathartes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175130;

    /// <inheritdoc />
    public virtual string GenusName => "Picathartes";

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
