using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Exoglossum;

/// <summary>
/// Abstract class for Exoglossum (genus).
/// NCBI TaxId: 86941
/// </summary>
public abstract class Exoglossum : Leuciscidae, IExoglossum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exoglossum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86941;

    /// <inheritdoc />
    public virtual string GenusName => "Exoglossum";

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
