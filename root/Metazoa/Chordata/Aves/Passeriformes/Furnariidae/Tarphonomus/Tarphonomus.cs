using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Tarphonomus;

/// <summary>
/// Abstract class for Tarphonomus (genus).
/// NCBI TaxId: 2823205
/// </summary>
public abstract class Tarphonomus : Furnariidae, ITarphonomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tarphonomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823205;

    /// <inheritdoc />
    public virtual string GenusName => "Tarphonomus";

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
