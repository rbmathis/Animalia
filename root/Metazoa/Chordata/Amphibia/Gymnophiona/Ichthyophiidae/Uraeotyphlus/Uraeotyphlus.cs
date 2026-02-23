using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Uraeotyphlus;

/// <summary>
/// Abstract class for Uraeotyphlus (genus).
/// NCBI TaxId: 194401
/// </summary>
public abstract class Uraeotyphlus : Ichthyophiidae, IUraeotyphlus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uraeotyphlus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 194401;

    /// <inheritdoc />
    public virtual string GenusName => "Uraeotyphlus";

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
