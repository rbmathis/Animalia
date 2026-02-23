using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Ereuniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Ereuniidae.Ereunias;

/// <summary>
/// Abstract class for Ereunias (genus).
/// NCBI TaxId: 1633497
/// </summary>
public abstract class Ereunias : Ereuniidae, IEreunias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ereunias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633497;

    /// <inheritdoc />
    public virtual string GenusName => "Ereunias";

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
