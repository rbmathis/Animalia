using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Grus;

/// <summary>
/// Abstract class for Grus (genus).
/// NCBI TaxId: 9114
/// </summary>
public abstract class Grus : Gruidae, IGrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9114;

    /// <inheritdoc />
    public virtual string GenusName => "Grus";

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
