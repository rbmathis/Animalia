using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gammogobius;

/// <summary>
/// Abstract class for Gammogobius (genus).
/// NCBI TaxId: 1365685
/// </summary>
public abstract class Gammogobius : Gobiidae, IGammogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gammogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365685;

    /// <inheritdoc />
    public virtual string GenusName => "Gammogobius";

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
