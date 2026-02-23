using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Chesnonia;

/// <summary>
/// Abstract class for Chesnonia (genus).
/// NCBI TaxId: 740927
/// </summary>
public abstract class Chesnonia : Agonidae, IChesnonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chesnonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 740927;

    /// <inheritdoc />
    public virtual string GenusName => "Chesnonia";

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
