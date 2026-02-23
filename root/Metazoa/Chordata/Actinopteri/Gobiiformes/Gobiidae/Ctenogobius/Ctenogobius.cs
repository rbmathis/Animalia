using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ctenogobius;

/// <summary>
/// Abstract class for Ctenogobius (genus).
/// NCBI TaxId: 168166
/// </summary>
public abstract class Ctenogobius : Gobiidae, ICtenogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 168166;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenogobius";

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
