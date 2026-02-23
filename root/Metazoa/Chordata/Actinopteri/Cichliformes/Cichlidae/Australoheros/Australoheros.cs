using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Australoheros;

/// <summary>
/// Abstract class for Australoheros (genus).
/// NCBI TaxId: 318581
/// </summary>
public abstract class Australoheros : Cichlidae, IAustraloheros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Australoheros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318581;

    /// <inheritdoc />
    public virtual string GenusName => "Australoheros";

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
