using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Buphagus;

/// <summary>
/// Abstract class for Buphagus (genus).
/// NCBI TaxId: 245047
/// </summary>
public abstract class Buphagus : Sturnidae, IBuphagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Buphagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245047;

    /// <inheritdoc />
    public virtual string GenusName => "Buphagus";

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
