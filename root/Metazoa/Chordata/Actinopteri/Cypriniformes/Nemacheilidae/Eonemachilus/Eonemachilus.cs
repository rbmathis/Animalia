using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Eonemachilus;

/// <summary>
/// Abstract class for Eonemachilus (genus).
/// NCBI TaxId: 2926448
/// </summary>
public abstract class Eonemachilus : Nemacheilidae, IEonemachilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eonemachilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2926448;

    /// <inheritdoc />
    public virtual string GenusName => "Eonemachilus";

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
