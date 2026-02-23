using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Incara;

/// <summary>
/// Abstract class for Incara (genus).
/// NCBI TaxId: 2888838
/// </summary>
public abstract class Incara : Eleotridae, IIncara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Incara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2888838;

    /// <inheritdoc />
    public virtual string GenusName => "Incara";

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
