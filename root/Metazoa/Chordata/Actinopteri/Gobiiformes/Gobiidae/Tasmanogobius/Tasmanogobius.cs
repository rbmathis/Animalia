using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Tasmanogobius;

/// <summary>
/// Abstract class for Tasmanogobius (genus).
/// NCBI TaxId: 613171
/// </summary>
public abstract class Tasmanogobius : Gobiidae, ITasmanogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tasmanogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 613171;

    /// <inheritdoc />
    public virtual string GenusName => "Tasmanogobius";

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
