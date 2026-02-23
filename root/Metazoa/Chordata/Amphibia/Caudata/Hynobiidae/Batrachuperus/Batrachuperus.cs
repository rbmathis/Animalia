using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Batrachuperus;

/// <summary>
/// Abstract class for Batrachuperus (genus).
/// NCBI TaxId: 156986
/// </summary>
public abstract class Batrachuperus : Hynobiidae, IBatrachuperus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batrachuperus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156986;

    /// <inheritdoc />
    public virtual string GenusName => "Batrachuperus";

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
