using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Dormitator;

/// <summary>
/// Abstract class for Dormitator (genus).
/// NCBI TaxId: 86229
/// </summary>
public abstract class Dormitator : Eleotridae, IDormitator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dormitator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86229;

    /// <inheritdoc />
    public virtual string GenusName => "Dormitator";

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
