using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Corcyrogobius;

/// <summary>
/// Abstract class for Corcyrogobius (genus).
/// NCBI TaxId: 1365677
/// </summary>
public abstract class Corcyrogobius : Gobiidae, ICorcyrogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corcyrogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365677;

    /// <inheritdoc />
    public virtual string GenusName => "Corcyrogobius";

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
