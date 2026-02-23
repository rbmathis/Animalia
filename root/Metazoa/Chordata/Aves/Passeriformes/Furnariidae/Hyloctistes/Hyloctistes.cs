using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Hyloctistes;

/// <summary>
/// Abstract class for Hyloctistes (genus).
/// NCBI TaxId: 589967
/// </summary>
public abstract class Hyloctistes : Furnariidae, IHyloctistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyloctistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589967;

    /// <inheritdoc />
    public virtual string GenusName => "Hyloctistes";

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
