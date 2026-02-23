using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Rectoris;

/// <summary>
/// Abstract class for Rectoris (genus).
/// NCBI TaxId: 291820
/// </summary>
public abstract class Rectoris : Cyprinidae, IRectoris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rectoris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 291820;

    /// <inheritdoc />
    public virtual string GenusName => "Rectoris";

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
