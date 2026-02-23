using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Didogobius;

/// <summary>
/// Abstract class for Didogobius (genus).
/// NCBI TaxId: 1365679
/// </summary>
public abstract class Didogobius : Gobiidae, IDidogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Didogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365679;

    /// <inheritdoc />
    public virtual string GenusName => "Didogobius";

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
