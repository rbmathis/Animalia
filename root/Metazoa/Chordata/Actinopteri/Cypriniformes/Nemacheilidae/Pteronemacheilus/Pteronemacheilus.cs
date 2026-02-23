using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Pteronemacheilus;

/// <summary>
/// Abstract class for Pteronemacheilus (genus).
/// NCBI TaxId: 1617391
/// </summary>
public abstract class Pteronemacheilus : Nemacheilidae, IPteronemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteronemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1617391;

    /// <inheritdoc />
    public virtual string GenusName => "Pteronemacheilus";

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
