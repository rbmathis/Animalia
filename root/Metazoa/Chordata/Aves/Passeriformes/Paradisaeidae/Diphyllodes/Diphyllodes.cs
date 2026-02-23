using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Diphyllodes;

/// <summary>
/// Abstract class for Diphyllodes (genus).
/// NCBI TaxId: 28715
/// </summary>
public abstract class Diphyllodes : Paradisaeidae, IDiphyllodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diphyllodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28715;

    /// <inheritdoc />
    public virtual string GenusName => "Diphyllodes";

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
