using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ctenogobiops;

/// <summary>
/// Abstract class for Ctenogobiops (genus).
/// NCBI TaxId: 166742
/// </summary>
public abstract class Ctenogobiops : Gobiidae, ICtenogobiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenogobiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166742;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenogobiops";

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
