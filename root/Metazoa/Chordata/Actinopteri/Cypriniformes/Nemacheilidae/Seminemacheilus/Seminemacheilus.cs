using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Seminemacheilus;

/// <summary>
/// Abstract class for Seminemacheilus (genus).
/// NCBI TaxId: 1483687
/// </summary>
public abstract class Seminemacheilus : Nemacheilidae, ISeminemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Seminemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1483687;

    /// <inheritdoc />
    public virtual string GenusName => "Seminemacheilus";

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
