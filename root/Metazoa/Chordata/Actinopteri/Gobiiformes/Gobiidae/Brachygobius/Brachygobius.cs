using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Brachygobius;

/// <summary>
/// Abstract class for Brachygobius (genus).
/// NCBI TaxId: 150290
/// </summary>
public abstract class Brachygobius : Gobiidae, IBrachygobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachygobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150290;

    /// <inheritdoc />
    public virtual string GenusName => "Brachygobius";

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
