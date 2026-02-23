using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Ellopostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Ellopostomatidae.Ellopostoma;

/// <summary>
/// Abstract class for Ellopostoma (genus).
/// NCBI TaxId: 533310
/// </summary>
public abstract class Ellopostoma : Ellopostomatidae, IEllopostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ellopostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 533310;

    /// <inheritdoc />
    public virtual string GenusName => "Ellopostoma";

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
