using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Nothocrax;

/// <summary>
/// Abstract class for Nothocrax (genus).
/// NCBI TaxId: 125064
/// </summary>
public abstract class Nothocrax : Cracidae, INothocrax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nothocrax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125064;

    /// <inheritdoc />
    public virtual string GenusName => "Nothocrax";

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
