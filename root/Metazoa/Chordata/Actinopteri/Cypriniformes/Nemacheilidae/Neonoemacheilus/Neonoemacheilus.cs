using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Neonoemacheilus;

/// <summary>
/// Abstract class for Neonoemacheilus (genus).
/// NCBI TaxId: 643432
/// </summary>
public abstract class Neonoemacheilus : Nemacheilidae, INeonoemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neonoemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643432;

    /// <inheritdoc />
    public virtual string GenusName => "Neonoemacheilus";

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
