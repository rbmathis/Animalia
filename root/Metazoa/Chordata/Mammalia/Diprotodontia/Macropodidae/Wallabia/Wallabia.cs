using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Wallabia;

/// <summary>
/// Abstract class for Wallabia (genus).
/// NCBI TaxId: 9329
/// </summary>
public abstract class Wallabia : Macropodidae, IWallabia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wallabia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9329;

    /// <inheritdoc />
    public virtual string GenusName => "Wallabia";

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
