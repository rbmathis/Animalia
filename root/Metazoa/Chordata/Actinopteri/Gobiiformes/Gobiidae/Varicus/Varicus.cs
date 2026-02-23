using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Varicus;

/// <summary>
/// Abstract class for Varicus (genus).
/// NCBI TaxId: 1182211
/// </summary>
public abstract class Varicus : Gobiidae, IVaricus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Varicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182211;

    /// <inheritdoc />
    public virtual string GenusName => "Varicus";

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
