using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Nematabramis;

/// <summary>
/// Abstract class for Nematabramis (genus).
/// NCBI TaxId: 432418
/// </summary>
public abstract class Nematabramis : Danionidae, INematabramis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nematabramis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432418;

    /// <inheritdoc />
    public virtual string GenusName => "Nematabramis";

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
