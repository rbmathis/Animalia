using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Nemacheilus;

/// <summary>
/// Abstract class for Nemacheilus (genus).
/// NCBI TaxId: 98925
/// </summary>
public abstract class Nemacheilus : Nemacheilidae, INemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98925;

    /// <inheritdoc />
    public virtual string GenusName => "Nemacheilus";

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
