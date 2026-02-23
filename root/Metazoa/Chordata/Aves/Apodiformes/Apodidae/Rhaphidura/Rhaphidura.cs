using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Rhaphidura;

/// <summary>
/// Abstract class for Rhaphidura (genus).
/// NCBI TaxId: 3150771
/// </summary>
public abstract class Rhaphidura : Apodidae, IRhaphidura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhaphidura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150771;

    /// <inheritdoc />
    public virtual string GenusName => "Rhaphidura";

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
