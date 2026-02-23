using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Cynomacrurus;

/// <summary>
/// Abstract class for Cynomacrurus (genus).
/// NCBI TaxId: 948058
/// </summary>
public abstract class Cynomacrurus : Macrouridae, ICynomacrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynomacrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948058;

    /// <inheritdoc />
    public virtual string GenusName => "Cynomacrurus";

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
