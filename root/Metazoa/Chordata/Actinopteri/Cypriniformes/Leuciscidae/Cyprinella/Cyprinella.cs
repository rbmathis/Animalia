using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Cyprinella;

/// <summary>
/// Abstract class for Cyprinella (genus).
/// NCBI TaxId: 13476
/// </summary>
public abstract class Cyprinella : Leuciscidae, ICyprinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyprinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13476;

    /// <inheritdoc />
    public virtual string GenusName => "Cyprinella";

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
