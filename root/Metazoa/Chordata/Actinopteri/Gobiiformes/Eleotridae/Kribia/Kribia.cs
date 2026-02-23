using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Kribia;

/// <summary>
/// Abstract class for Kribia (genus).
/// NCBI TaxId: 308082
/// </summary>
public abstract class Kribia : Eleotridae, IKribia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kribia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 308082;

    /// <inheritdoc />
    public virtual string GenusName => "Kribia";

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
