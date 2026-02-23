using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Guadalcanaria;

/// <summary>
/// Abstract class for Guadalcanaria (genus).
/// NCBI TaxId: 1439374
/// </summary>
public abstract class Guadalcanaria : Meliphagidae, IGuadalcanaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guadalcanaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1439374;

    /// <inheritdoc />
    public virtual string GenusName => "Guadalcanaria";

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
