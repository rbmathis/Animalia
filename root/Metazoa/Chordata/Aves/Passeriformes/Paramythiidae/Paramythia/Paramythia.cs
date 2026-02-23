using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paramythiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paramythiidae.Paramythia;

/// <summary>
/// Abstract class for Paramythia (genus).
/// NCBI TaxId: 254573
/// </summary>
public abstract class Paramythia : Paramythiidae, IParamythia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paramythia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254573;

    /// <inheritdoc />
    public virtual string GenusName => "Paramythia";

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
