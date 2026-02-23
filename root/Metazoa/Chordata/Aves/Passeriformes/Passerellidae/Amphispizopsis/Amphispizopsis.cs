using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Amphispizopsis;

/// <summary>
/// Abstract class for Amphispizopsis (genus).
/// NCBI TaxId: 3150808
/// </summary>
public abstract class Amphispizopsis : Passerellidae, IAmphispizopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amphispizopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150808;

    /// <inheritdoc />
    public virtual string GenusName => "Amphispizopsis";

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
