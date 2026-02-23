using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Hemispingus;

/// <summary>
/// Abstract class for Hemispingus (genus).
/// NCBI TaxId: 62202
/// </summary>
public abstract class Hemispingus : Fringillidae, IHemispingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemispingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62202;

    /// <inheritdoc />
    public virtual string GenusName => "Hemispingus";

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
