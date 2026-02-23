using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Spiza;

/// <summary>
/// Abstract class for Spiza (genus).
/// NCBI TaxId: 84853
/// </summary>
public abstract class Spiza : Cardinalidae, ISpiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84853;

    /// <inheritdoc />
    public virtual string GenusName => "Spiza";

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
