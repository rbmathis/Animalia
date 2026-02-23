using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Heminoemacheilus;

/// <summary>
/// Abstract class for Heminoemacheilus (genus).
/// NCBI TaxId: 2984017
/// </summary>
public abstract class Heminoemacheilus : Nemacheilidae, IHeminoemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heminoemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2984017;

    /// <inheritdoc />
    public virtual string GenusName => "Heminoemacheilus";

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
