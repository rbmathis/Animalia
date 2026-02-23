using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Dreptes;

/// <summary>
/// Abstract class for Dreptes (genus).
/// NCBI TaxId: 2575926
/// </summary>
public abstract class Dreptes : Nectariniidae, IDreptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dreptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2575926;

    /// <inheritdoc />
    public virtual string GenusName => "Dreptes";

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
