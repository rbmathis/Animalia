using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Anthreptes;

/// <summary>
/// Abstract class for Anthreptes (genus).
/// NCBI TaxId: 208074
/// </summary>
public abstract class Anthreptes : Nectariniidae, IAnthreptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthreptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208074;

    /// <inheritdoc />
    public virtual string GenusName => "Anthreptes";

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
