using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Corematodus;

/// <summary>
/// Abstract class for Corematodus (genus).
/// NCBI TaxId: 323765
/// </summary>
public abstract class Corematodus : Cichlidae, ICorematodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corematodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 323765;

    /// <inheritdoc />
    public virtual string GenusName => "Corematodus";

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
