using AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Ardeotis;

/// <summary>
/// Abstract class for Ardeotis (genus).
/// NCBI TaxId: 54376
/// </summary>
public abstract class Ardeotis : Otididae, IArdeotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ardeotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54376;

    /// <inheritdoc />
    public virtual string GenusName => "Ardeotis";

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
