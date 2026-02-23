using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Karstsinnectes;

/// <summary>
/// Abstract class for Karstsinnectes (genus).
/// NCBI TaxId: 3109566
/// </summary>
public abstract class Karstsinnectes : Nemacheilidae, IKarstsinnectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Karstsinnectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3109566;

    /// <inheritdoc />
    public virtual string GenusName => "Karstsinnectes";

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
