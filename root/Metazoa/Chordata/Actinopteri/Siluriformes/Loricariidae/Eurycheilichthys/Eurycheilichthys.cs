using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Eurycheilichthys;

/// <summary>
/// Abstract class for Eurycheilichthys (genus).
/// NCBI TaxId: 510927
/// </summary>
public abstract class Eurycheilichthys : Loricariidae, IEurycheilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurycheilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 510927;

    /// <inheritdoc />
    public virtual string GenusName => "Eurycheilichthys";

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
